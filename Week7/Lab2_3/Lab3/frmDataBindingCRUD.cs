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
    public partial class frmDataBindingCRUD : Form
    {
        public frmDataBindingCRUD()
        {
            InitializeComponent();
        }

        private void frmDataBindingCRUD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet.CLASS' table. You can move, or remove it, as needed.
            this.cLASSTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet.CLASS);

        }
        string stringconn = "Data Source=HOANGLONG\\HOANGLONG;Initial Catalog=ConnectDB;User ID=sa;Password=12345";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void btnView_Click(object sender, EventArgs e)
        {
            string str = $"Select * from student where classID='{cboClassID.Text}'";
            adapter = new SqlDataAdapter(str, stringconn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
