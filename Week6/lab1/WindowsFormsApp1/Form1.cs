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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        string stringconn = "Data Source=HOANGLONG\\HOANGLONG;Initial Catalog=ConnectDB;User ID=sa;Password=12345;MultipleActiveResultSets=true";

        void ClassInfo(object sender, EventArgs e)
        {

            txtClassIDDB.Text = String.Empty;
            txtClassName.Text = string.Empty;
            txtYear.Text = String.Empty;

            if (connection == null) connection = new SqlConnection(stringconn);
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = $"select * from Class where ClassID ='{txtClassID.Text}'";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtClassIDDB.Text = reader.GetString(0);
                txtClassName.Text = reader.GetString(1);
                txtYear.Text = reader.GetInt32(2).ToString();
            }
            
            connection.Close();
        }

        void ListStudentOfClass(object sender, EventArgs e)
        {
            lsvStudents.Items.Clear();

            if (connection == null) connection = new SqlConnection(stringconn);
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand command = new SqlCommand($"select * from Student where ClassID='{txtClassIDDB.Text}'", connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string studentName = reader.GetString(1);
                string classID = reader.GetString(2);
                ListViewItem student = new ListViewItem(studentID);

                student.SubItems.Add(studentName);
                student.SubItems.Add(classID);
                lsvStudents.Items.Add(student);
            }
            connection.Close();
        }
        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            ClassInfo(sender,e);
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            ListStudentOfClass(sender,e);
        }

        private void txtClassID_TextChanged(object sender, EventArgs e)
        {
            ClassInfo(sender, e);
            ListStudentOfClass(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsvStudents.Columns.Add("Student ID", 100);
            lsvStudents.Columns.Add("Name", 100);
            lsvStudents.Columns.Add("Class ID", 100);
            lsvStudents.View = View.Details;
        }
    }
}
