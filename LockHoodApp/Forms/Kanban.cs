using Microsoft.Data.Sqlite;
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
        private enum StatusTypes { todo, inprogress, testing, finished }

        private void Migrate()
        {
            using (var connection = new SqliteConnection("Data Source=hello.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    CREATE TABLE IF NOT EXISTS tasks (id INTEGER PRIMARY KEY AUTOINCREMENT, task TEXT,status TEXT);
                    INSERT INTO tasks (task,status) VALUES('task1','todo'),('task2','todo'),('task3','todo'),('task4','todo');
                ";

            }
        }

        private void getTasks()
        {
            dgvTodo.Rows.Clear();
            dgvTesting.Rows.Clear();
            dgvInProgress.Rows.Clear();
            dgvFinished.Rows.Clear();

            using (var connection = new SqliteConnection("Data Source=hello.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT * from tasks;
                ";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string[] list = new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2) };
                        switch (list[2])
                        {
                            case "todo":
                                dgvTodo.Rows.Add(list);
                                break;
                            case "testing":
                                dgvTesting.Rows.Add(list);
                                break;
                            case "finished":
                                dgvFinished.Rows.Add(list);
                                break;
                            case "inprogress":
                                dgvInProgress.Rows.Add(list);
                                break;
                        }
                    }
                }
            }
        }

        private void Kanban_Load(object sender, EventArgs e)
        {
            Migrate();
        }

        private void dgvTodo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void changeState(StatusTypes changeto)
        {

            using (var connection = new SqliteConnection("Data Source=hello.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $@"
                    update tasks set status='{changeto}' where id={currentTaskID}
                ";
               

                command.ExecuteNonQuery();

            }
            getTasks();
        }


        private void dgvTesting_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentTaskID = dgvTesting.Rows[e.ColumnIndex - 1].Cells[0].Value.ToString();
        }

        private void dgvTodo_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentTaskID = dgvTodo.Rows[e.ColumnIndex - 1].Cells[0].Value.ToString();
        }

        private void ContextmenustripItem_Click(object sender, EventArgs e)
        {
            changeState( StatusTypes.inprogress);
        }

        private void ContextmenustripItem2_Click(object sender, EventArgs e)
        {
            changeState( StatusTypes.testing);
        }

        private void ContextmenustripItem3_Click(object sender, EventArgs e)
        {
            changeState( StatusTypes.finished);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            changeState(StatusTypes.todo);
        }

        private void Kanban_Shown(object sender, EventArgs e)
        {
            getTasks();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            changeState(StatusTypes.inprogress);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            changeState(StatusTypes.finished);
        }

        private void iNPROGRESSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvInProgress_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentTaskID = dgvInProgress.Rows[e.ColumnIndex - 1].Cells[0].Value.ToString();
        }

        private void dgvFinished_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentTaskID = dgvFinished.Rows[e.ColumnIndex - 1].Cells[0].Value.ToString();
        }
    }
}
