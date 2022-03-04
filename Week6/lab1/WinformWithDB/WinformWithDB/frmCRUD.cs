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

namespace WinformWithDB
{
    public partial class frmCRUD : Form
    {
        public frmCRUD()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        string stringconn= "Data Source=HOANGLONG\\HOANGLONG;Initial Catalog=ConnectDB;User ID=sa;Password=12345";

        private void frmCRUD_Load(object sender, EventArgs e)
        {
            //var stringBuilder = new SqlConnectionStringBuilder();
            //stringBuilder["Server"] = "HOANGLONG\\HOANGLONG";
            //// stringBuilder["Initial Catalog"] = "ConnectDB";
            //stringBuilder["Database"] = "ConnectDB";
            //stringBuilder["Integrated Security"] = "True";
            //stringBuilder["MultipleActiveResultSets"] = "True";
            //stringBuilder["User ID"] = "sa";
            //stringBuilder["Password"] = "12345";
            //stringconn = stringBuilder.ToString();
            //connection = new SqlConnection(stringBuilder.ToString());
            //connection.Open();

            lsvStudents.Columns.Add("Student ID", 100);
            lsvStudents.Columns.Add("Name", 100);
            lsvStudents.Columns.Add("Class ID", 100);
            lsvStudents.View = View.Details;
            ViewListofStudents();
        }

        private void ViewListofStudents()
        {
            lsvStudents.Items.Clear();

            if (connection == null) connection = new SqlConnection(stringconn);
            if (connection.State == ConnectionState.Closed) connection.Open();

            SqlCommand command = new SqlCommand("Select * from Student", connection);

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classIDRow = reader.GetString(2);

                ListViewItem item = lsvStudents.Items.Add(studentID);
                item.SubItems.Add(name);
                item.SubItems.Add(classIDRow);
            }
            connection.Close();
        }

        private void lsvStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvStudents.SelectedItems.Count > 0)
            {
                txtStudentID.Text = lsvStudents.SelectedItems[0].SubItems[0].Text;
                txtFullName.Text = lsvStudents.SelectedItems[0].SubItems[1].Text;
                txtClassID.Text = lsvStudents.SelectedItems[0].SubItems[2].Text;

            }
        }

        private int result = -1;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (connection == null) connection = new SqlConnection(stringconn);
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "insert into Student(StudentID,Name,ClassID)" + "values(@StudentID,@Name,@ClassID)";
            SqlParameter parameter1 = new SqlParameter("@StudentID", txtStudentID.Text);
            command.Parameters.Add(parameter1);
            SqlParameter parameter2 = new SqlParameter("@Name", txtFullName.Text);
            command.Parameters.Add(parameter2);
            SqlParameter parameter3 = new SqlParameter("@ClassID", txtClassID.Text);
            command.Parameters.Add(parameter3);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + "Insert failed");
                throw;
            }

            if (result > 0)
            {
                ViewListofStudents();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (connection == null) connection = new SqlConnection(stringconn);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command =
                new SqlCommand(
                    $"update Student set Name='{txtFullName.Text}', ClassID='{txtClassID.Text}' where StudentID='{txtStudentID.Text}'",connection);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + "Update failed");
                throw;
            }

            if (result > 0)
            {
                ViewListofStudents();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (connection == null) connection = new SqlConnection(stringconn);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand($"Delete from Student where StudentID='{txtStudentID.Text}'", connection);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + "Delete failed");
                throw;
            }
            if (result > 0)
            {
                ViewListofStudents();
            }
        }
    }
}
