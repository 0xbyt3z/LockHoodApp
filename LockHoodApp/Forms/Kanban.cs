using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockHoodApp.Forms
{
    public partial class Kanban : Form
    {
        public Kanban()
        {
            InitializeComponent();
        }

        private string currentTaskID;
        private enum StatusTypes {TODO,INPROGRESS,TESTING,FINISHED}

        private void Kanban_Load(object sender, EventArgs e)
        {
            string[] arr = new string[] { "124","Task 1" };

            dgvTodo.Rows.Add(arr);
            dgvInProgress.Rows.Add(arr);
            dgvTesting.Rows.Add(arr);
            dgvFinished.Rows.Add(arr);
        }

        private void dgvTodo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void changeState(StatusTypes type,StatusTypes changeto)
        {
            MessageBox.Show(type+":"+changeto+":"+ currentTaskID);
        }


        private void dgvTesting_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dgvTesting.Rows[e.ColumnIndex-1].Cells[0].Value.ToString();
            if (e.Button == MouseButtons.Right)
            {
                cmsTesting.Show(this.PointToScreen(e.Location));
                MessageBox.Show(id);
            }
        }

        private void dgvTodo_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dgvTesting.Rows[e.ColumnIndex-1].Cells[0].Value.ToString();
            if (e.Button == MouseButtons.Right)
            {
                cmsTodo.Show(this.PointToScreen(e.Location));
                currentTaskID = id;
            }
        }

        private void ContextmenustripItem_Click(object sender, EventArgs e)
        {
            changeState(StatusTypes.TODO, StatusTypes.INPROGRESS);
        }

        private void ContextmenustripItem2_Click(object sender, EventArgs e)
        {
            changeState(StatusTypes.TODO, StatusTypes.TESTING);
        }

        private void ContextmenustripItem3_Click(object sender, EventArgs e)
        {
            changeState(StatusTypes.TODO, StatusTypes.FINISHED);
        }
    }
}
