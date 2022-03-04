using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformWithDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //connect to database
            var stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder["Server"] = "HOANGLONG\\HOANGLONG";
            // stringBuilder["Initial Catalog"] = "ConnectDB";
            stringBuilder["Database"] = "ConnectDB";
            stringBuilder["Integrated Security"] = "True";
            stringBuilder["MultipleActiveResultSets"] = "True";
            stringBuilder["User ID"] = "sa";
            stringBuilder["Password"] = "12345";
            SqlConnection connection = new SqlConnection(stringBuilder.ToString());
            connection.Open();
            
            //get data
            SqlCommand command = new SqlCommand("select * from dbo.Class", connection);
            SqlDataAdapter adapter = new SqlDataAdapter((command));
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dgvClass.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmQueryData = new frmQueryData();
            frmQueryData.Show();
        }
    }
}