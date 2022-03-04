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
    public partial class frmForm2 : Form
    {
        public frmForm2()
        {
            InitializeComponent();

            lvStudents.Columns.Add("Student ID", 100);
            lvStudents.Columns.Add("Name", 100);
            lvStudents.Columns.Add("Class ID", 100);
            lvStudents.View = View.Details;

        }

        private SqlConnection connection;
        SqlDataAdapter adapter = null;
        DataSet dataSet = null;
        string stringconn = "Data Source=HOANGLONG\\HOANGLONG;Initial Catalog=ConnectDB;User ID=sa;Password=12345";

        private void frmForm2_Load(object sender, EventArgs e)
        {

            //var stringBuilder = new SqlConnectionStringBuilder();
            //stringBuilder["Server"] = "HOANGLONG\\HOANGLONG";
            //// stringBuilder["Initial Catalog"] = "ConnectDB";
            //stringBuilder["Database"] = "ConnectDB";
            //stringBuilder["Integrated Security"] = "True";
            //stringBuilder["MultipleActiveResultSets"] = "True";
            //stringBuilder["User ID"] = "sa";
            //stringBuilder["Password"] = "12345";
            connection = new SqlConnection(stringconn);
            connection.Open();

            SqlCommand command = new SqlCommand($"Select * from Class as tblClassID", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tblClassID");
            cbxClassID.DataSource = ds.Tables["tblClassID"];
            cbxClassID.DisplayMember = "ClassID";
            cbxClassID.ValueMember = "ClassID";


            string classID = cbxClassID.SelectedValue.ToString().Trim();

            SqlCommand command1 = new SqlCommand("select * from dbo.Student Where ClassID = '{classID}' ", connection);
            SqlDataAdapter adapter1 = new SqlDataAdapter((command));
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
        }

        private void btnViewInDetail_Click(object sender, EventArgs e)
        {
            QueryData(sender,e);
        }

        private void QueryData(object sender, EventArgs e)
        {
            if (connection == null) connection = new SqlConnection(stringconn);
            if (connection.State == ConnectionState.Closed) connection.Open();

            string classID = cbxClassID.SelectedValue.ToString().Trim();
            txtClassIDDB.Text = classID;


            SqlCommand command = new SqlCommand($"Select * from Class where ClassID = '{classID}'", connection);
            SqlDataReader reader = command.ExecuteReader();


            if (reader.Read())
            {
                txtClassIDDB.Text = reader.GetString(0);
                txtClassName.Text = reader.GetString(1);
                txtYear.Text = reader.GetInt32(2).ToString();

            }
            connection.Close();
        }

        private void cbxClassID_SelectedIndexChanged(object sender, EventArgs e)
        {
            QueryData(sender, e);
            QueryMoreDetail(sender,e);
        }

        private void QueryMoreDetail(object sender, EventArgs e)
        {
            if (connection == null) connection = new SqlConnection(stringconn);
            if (connection.State == ConnectionState.Closed) connection.Open();

            string classID = cbxClassID.SelectedValue.ToString().Trim();

            SqlCommand command = new SqlCommand("select * from dbo.Student Where ClassID = '{classID}' ", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string studentName = reader.GetString(1);
                classID = reader.GetString(2);
                ListViewItem item = new ListViewItem(studentID);

                item.SubItems.Add(studentName);
                item.SubItems.Add(classID);
                lvStudents.Items.Add(item);
            }
        }
        

        private void btnViewListSutdents_Click(object sender, EventArgs e)
        {
            lvStudents.Items.Clear();
            QueryMoreDetail(sender, e);
            connection.Close();
        }
    }
}
