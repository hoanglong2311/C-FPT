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

namespace DE150191_PRACTICAL
{
    public partial class frmSearchBookByName : Form
    {
        public frmSearchBookByName()
        {
            InitializeComponent();
        }

        private static frmSearchBookByName instance;
        public static frmSearchBookByName GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmSearchBookByName();
                }
                return instance;
            }
        }

        string stringconn = "Data Source = HOANGLONG\\HOANGLONG;Initial Catalog = LibraryManagementSystem; User ID = sa; Password=12345";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter($"Select* from [BOOK] where [BOOKNAME] like '%{txtSearch.Text}%'", stringconn);
            ds = new DataSet();
            adapter.Fill(ds);
            dgvBookSearch.DataSource = ds.Tables[0];
        }
    }
}
