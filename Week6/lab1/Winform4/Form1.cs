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

namespace Winform4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        string stringconn = "Data Source=HOANGLONG\\HOANGLONG;Initial Catalog=ConnectDB;User ID=sa;Password=12345;MultipleActiveResultSets=true";
        private void Form1_Load(object sender, EventArgs e)
        {
            lsvStudent.Columns.Add("Student ID", 100);
            lsvStudent.Columns.Add("Name", 100);
            lsvStudent.Columns.Add("Class ID", 100);
            lsvStudent.View = View.Details; 

            if (connection == null) connection = new SqlConnection(stringconn);
            if (connection.State == ConnectionState.Closed) connection.Open();
            SqlCommand command = new SqlCommand("Select * from class",connection);
            
            lsbClass.ClearSelected();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string classID = reader.GetString(0);
                string className = reader.GetString(1);
                int year = reader.GetInt32(2);
                string line = classID + "-" + className + "-" + year;
                lsbClass.Items.Add(line);
            }
            connection.Close();
        }

        private void lsbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvStudent.Items.Clear();
            if (lsbClass.SelectedIndex == -1) return;
            string line = lsbClass.SelectedItem.ToString();
            string[] array = line.Split('-');
            string classID = array[0];


            if (connection == null) connection = new SqlConnection(stringconn);
            if (connection.State == ConnectionState.Closed) connection.Open();

            SqlCommand command = new SqlCommand($"Select * from Student where ClassID = '{classID}'", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classIDRow = reader.GetString(2);

                ListViewItem student = lsvStudent.Items.Add(studentID);
                student.SubItems.Add(name);
                student.SubItems.Add(classIDRow);

            }
            connection.Close();
        }
    }
}
