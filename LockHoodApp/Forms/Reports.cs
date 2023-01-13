using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using iText.Kernel.Pdf;
using iText.Kernel.Geom;
using iText.Layout;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;
using System.Text.RegularExpressions;

namespace LockHoodApp.Forms
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        public void generateInvoice()
        {
            //this method will create a pdf in the following directory
            int jobID = 23523;
            decimal totalSales = 0;
            string path = "reports/invoice";
            string filename = String.Format("{0}.pdf", DateTime.Now.ToString("ddMMss"));
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            PdfWriter writer = new PdfWriter(filename);
            PdfDocument pdf = new PdfDocument(writer);
            iText.Layout.Document document = new iText.Layout.Document(pdf, PageSize.A4);
            document.SetMargins(10, 20, 10, 20);
            Paragraph header = new Paragraph("Lock Hood").SetTextAlignment(TextAlignment.LEFT).SetFontSize(36).SetMultipliedLeading(.3f).SetBold().SetFontColor(iText.Kernel.Colors.ColorConstants.BLUE).SetPaddingLeft(-3);
            Paragraph info = new Paragraph("Your security is the fisrt priority").SetTextAlignment(TextAlignment.LEFT).SetFontSize(8);

            Paragraph invoice = new Paragraph(String.Format("Invoice"));
            invoice.SetTextAlignment(TextAlignment.LEFT).SetFontSize(12).SetStrokeWidth(9).SetPaddingLeft(-3);

            //stored procedure passing selected job as the parameter
            //create a multi-lined paragraph containing job information
            string q = "call get_job(" + jobID.ToString() + ")";
            string jinfo =
                    "ID : 534254\n" +
                    "Customer Name : Alex Fernando\n" +
                    "Address : No.34 Galle Rd, Kaluthara\n" +
                    "Date : "+ DateTime.Now.ToString("yyyy-MM-dd");

            Paragraph jobinfo = new Paragraph(jinfo).SetTextAlignment(TextAlignment.LEFT).SetFontSize(8);

            Paragraph customer = new Paragraph(String.Format("Report as at - {0}", DateTime.Now.ToString("yyyy-MM-dd")));
            customer.SetTextAlignment(TextAlignment.RIGHT).SetFontSize(9);

            Paragraph verticalPadding = new Paragraph("\n").SetFontSize(8).SetMultipliedLeading(0.3f);

            Table headerTable = new Table(new float[] { 70, 30 }, true);

            //add customer to right
            Cell right_cell = new Cell();
            right_cell.SetBorder(Border.NO_BORDER);
            right_cell.Add(invoice);
            headerTable.AddCell(right_cell);

            //add info to left
            Cell left_cell = new Cell();
            left_cell.SetBorder(Border.NO_BORDER);
            left_cell.Add(customer);
            headerTable.AddCell(left_cell);

            Table table = new Table(new float[] { 20, 90, 50, 50, 30,40 }, true).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER).SetFontSize(8);
            string[] headers = new string[] { "#", "Product Name", "Quantity", "Discount", "Price", "Total" };

            //add the headers to the table
            foreach (var item in headers)
            {
                Cell headercell = new Cell();
                headercell.SetBorder(Border.NO_BORDER);
                headercell.SetFontSize(9);
                headercell.Add(new Paragraph(item));
                headercell.SetTextAlignment(TextAlignment.LEFT);
                //align product name to left and other cells to right
                if (item == "Price" | item == "Total")
                {
                    headercell.SetTextAlignment(TextAlignment.RIGHT);
                }

                table.AddCell(headercell);
            }



            int itemcount = 0;
            decimal totalWeight = 0;
            string[,] r = new string[,] { { "Double Door Lock", "4", "3%", "9500", "23435" }, { "Double Door Lock", "4", "3%", "9500", "234235235" } };
            int fontsize = 8;


            //follwing loop will create each cell and append in the order
            for (int _i = 0; _i < r.GetLength(0); _i++)
            {
                Cell line = new Cell().SetBorder(Border.NO_BORDER).SetFontSize(fontsize);
                Cell name = new Cell().SetBorder(Border.NO_BORDER).SetFontSize(fontsize);
                Cell quantity = new Cell().SetBorder(Border.NO_BORDER).SetFontSize(fontsize);
                Cell dis = new Cell().SetBorder(Border.NO_BORDER).SetFontSize(fontsize);
                Cell price = new Cell().SetBorder(Border.NO_BORDER).SetFontSize(fontsize);
                Cell total = new Cell().SetBorder(Border.NO_BORDER).SetFontSize(fontsize);

                line.Add(new Paragraph((itemcount + 1).ToString()));
                name.Add(new Paragraph(r[_i,0]));
                quantity.Add(new Paragraph(r[_i, 1]));
                dis.Add(new Paragraph(r[_i, 2].ToString()));
                price.Add(new Paragraph(r[_i, 3].ToString()).SetTextAlignment(TextAlignment.RIGHT));
                total.Add(new Paragraph(r[_i, 4].ToString()).SetTextAlignment(TextAlignment.RIGHT));

                //append cells to the table
                table.AddCell(line);
                table.AddCell(name);
                table.AddCell(quantity);
                table.AddCell(dis);
                table.AddCell(price);
                table.AddCell(total);

                itemcount++;
            }



            Table footer = new Table(2, true);

            Cell left = new Cell();
            left.SetBorder(Border.NO_BORDER);
            Cell right = new Cell();
            right.SetBorder(Border.NO_BORDER);

            //summary table
            Table summarytable = new Table(new float[] { 100, 60 }, false).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT).SetFontSize(10);

            //dashed line for cells
            Border dashed = new DashedBorder(.5f);
            Border doubled = new DoubleBorder(.5f);


            //discount total cell
            Cell payment = new Cell().SetFontSize(8);
            payment.SetBorder(Border.NO_BORDER);
            payment.Add(new Paragraph("Number of Items"));
            summarytable.AddCell(payment);

            //total discount value
            Cell paymentvalue = new Cell().SetFontSize(8);
            paymentvalue.SetBorder(Border.NO_BORDER);
            paymentvalue.SetTextAlignment(TextAlignment.RIGHT);
            paymentvalue.Add(new Paragraph(itemcount.ToString()));
            summarytable.AddCell(paymentvalue);

            //discount total cell
            Cell grandtotal = new Cell().SetFontSize(8);
            grandtotal.SetBorder(Border.NO_BORDER);
            grandtotal.Add(new Paragraph("Charges"));
            summarytable.AddCell(grandtotal);

            //total value
            Cell grandtotalvalue = new Cell().SetFontSize(8);
            grandtotalvalue.SetBorder(Border.NO_BORDER);
            grandtotalvalue.SetBorderBottom(doubled);
            grandtotalvalue.SetBorderTop(dashed);
            grandtotalvalue.SetTextAlignment(TextAlignment.RIGHT);
            grandtotalvalue.Add(new Paragraph(Convert.ToDecimal(34535).ToString("0.00")));
            summarytable.AddCell(grandtotalvalue);

            //add the summary table to right holder
            right.Add(summarytable);


            Paragraph trademark = new Paragraph("").SetFontSize(8).SetTextAlignment(TextAlignment.LEFT);

            //add left and right to the holder
            footer.AddCell(left);
            footer.AddCell(right);


            footer.SetKeepTogether(true);


            //organize the document
            document.Add(header);
            document.Add(info);
            document.Add(headerTable);
            document.Add(verticalPadding);
            document.Add(jobinfo);
            document.Add(verticalPadding);
            document.Add(table);
            document.Add(verticalPadding);
            document.Add(verticalPadding);
            document.Add(footer);
            document.Add(trademark);

            document.Close();

            //open the created pdf in the default pdf viewer
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(filename)
            {
                UseShellExecute = true
            };
            p.Start();
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            generateInvoice();
        }
    }
}
