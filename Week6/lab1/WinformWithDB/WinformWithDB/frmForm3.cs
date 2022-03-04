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
    public partial class frmForm3 : Form
    {
        public frmForm3()
        {
            InitializeComponent();
        }
        private SqlConnection connection;

        private void frmForm3_Load(object sender, EventArgs e)
        {

            var stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder["Server"] = "HOANGLONG\\HOANGLONG";
            // stringBuilder["Initial Catalog"] = "ConnectDB";
            stringBuilder["Database"] = "ConnectDB";
            stringBuilder["Integrated Security"] = "True";
            stringBuilder["MultipleActiveResultSets"] = "True";
            stringBuilder["User ID"] = "sa";
            stringBuilder["Password"] = "12345";
            connection = new SqlConnection(stringBuilder.ToString());
            connection.Open();



            lsbClass.ClearSelected();
            SqlCommand command = new SqlCommand("Select * from class", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string classID = reader.GetString(0);
                string className = reader.GetString(1);
                int year = reader.GetInt32(2);

                string line = classID + "-" + className + "-" + year;

                lsbClass.Items.Add(line);
            }

            lsvStudents.Columns.Add("Student ID", 100);
            lsvStudents.Columns.Add("Name", 100);
            lsvStudents.Columns.Add("Class ID", 100);
            lsvStudents.View = View.Details;
        }

        private void lsbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvStudents.Items.Clear();

            if (lsbClass.SelectedIndex == -1) return;
            string line = lsbClass.SelectedItem.ToString();
            string[] array = line.Split('-');
            string classID = array[0];

            SqlCommand command = new SqlCommand($"Select * from Student where classID='{classID}'", connection);

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
        }
    }
}
