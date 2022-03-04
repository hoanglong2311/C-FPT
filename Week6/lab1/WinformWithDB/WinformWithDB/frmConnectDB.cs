using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinformWithDB
{
    public partial class frmConnectDB : Form
    {
        public frmConnectDB()
        {
            InitializeComponent();
        }
        private SqlConnection connection;

        private void button1_Click(object sender, EventArgs e)
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
            // lbConnectStatus.Text = "Connected to database successfully!";
            // lbConnectStatus.ForeColor = System.Drawing.Color.Green;
            ConnectionStatus(sender, e);

        }

        public void ConnectionStatus(object sender, EventArgs e)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                lbConnectStatus.Text = "Connected to database successfully!";
                lbConnectStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbConnectStatus.Text = "Not connected to database!";
                lbConnectStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            connection.Close();
            // lbConnectStatus.Text = "Disconnected from database successfully!";
            // lbConnectStatus.ForeColor = System.Drawing.Color.Red;
            ConnectionStatus(sender, e);
        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            Form formProgram = new frmProgram();
            formProgram.Show();
        }
    }
}