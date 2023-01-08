using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockHoodApp
{
    internal class connection
    {
        SqlConnection con;

        public connection()
        {
            con = new SqlConnection("Data Source=DESKTOP-GQJGJ7E\\SQLEXPRESS;Initial Catalog=lockhoodapp;Integrated Security=True");
        }

        public SqlConnection opencon()
        {
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                // throw;
            }

            return con;
        }

        public void conclose()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
