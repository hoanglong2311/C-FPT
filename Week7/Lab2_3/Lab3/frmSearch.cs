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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }
        string stringconn = "Data Source=HOANGLONG\\HOANGLONG;Initial Catalog=ConnectDB;User ID=sa;Password=12345";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void txtEnterName_TextChanged(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter($"Select * from student where name like '%{txtEnterName.Text}%'", stringconn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
