using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        //SqlConnection connection;
        string stringconn = "Data Source=HOANGLONG\\HOANGLONG;Initial Catalog=ConnectDB;User ID=sa;Password=12345";
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * from student", stringconn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "Student");
            //dtgStudent.DataSource = ds.Tables[0]

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dtgStudent.DataSource = ds.Tables[0];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int result = 0;
            //create a new row
            DataRow row = ds.Tables[0].NewRow();
            row[0] = txtStudentID.Text;
            row["Name"] = txtStudentName.Text;
            row[2] = txtClassID.Text;

            //add the row to Dataset
            ds.Tables[0].Rows.Add(row);
            //update adapter
            try
            {
                adapter.Update(ds, "Student");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Insert Failed " + exception.Message);
                throw;
            }

            if (result>0)
            {
                MessageBox.Show("Insert Successfully ");

            }
        }

        private int position = -1;
        private void dtgStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            if (position != -1)
            {
                DataRow row = ds.Tables[0].Rows[position];
                txtStudentID.Text = row[0].ToString();
                txtStudentName.Text = row["Name"].ToString();
                txtClassID.Text = row[2].ToString();
            }
            else
            {
                MessageBox.Show("No row is selected");
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (position != -1)
            {
                DataRow row = ds.Tables[0].Rows[position];
                //edit row
                row.BeginEdit();
                row[0] = txtStudentID.Text;
                //row["Name"] = txtStudentName.Text;
                row[1] = txtStudentName.Text;
                row[2] = txtClassID.Text;
                row.EndEdit();
                int result = adapter.Update(ds.Tables[0]);
                if (result>0)
                {
                    MessageBox.Show("Update successfully");
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
            else
            {
                MessageBox.Show("No row is selected");
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (position != -1)
            {
                DataRow row = ds.Tables[0].Rows[position];
                row.Delete();
                int result = adapter.Update(ds.Tables[0]);
                if (result > 0)
                {
                    MessageBox.Show("Delete successfully");
                }
                else
                {
                    MessageBox.Show("Delete failed");
                }
            }
        }
    }
}
