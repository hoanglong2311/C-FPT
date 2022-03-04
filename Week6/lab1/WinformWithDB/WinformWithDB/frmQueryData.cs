using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinformWithDB
{
    
    public partial class frmQueryData : Form
    {
        
        public frmQueryData()
        {
            InitializeComponent();
        }

        private SqlConnection connection;
        private void btnCalNumStudent_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"Select count(*) from STUDENT where ClassID = '{txtClassID.Text}'", connection);
            int result = (int) command.ExecuteScalar();
            txtNumberOfStudents.Text = result.ToString();
            connection.Close();
        }

        private void frmQueryData_Load(object sender, EventArgs e)
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
        }
    }
}