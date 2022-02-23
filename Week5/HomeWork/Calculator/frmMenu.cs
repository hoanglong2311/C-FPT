using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCongTruNhanChia_Click(object sender, EventArgs e)
        {
            Form frmCongTruNhanChia = new CongTruNhanChia();
            frmCongTruNhanChia.Show();
        }

        private void btnUocBoi_Click(object sender, EventArgs e)
        {
            Form frmUocBoi = new frmUocBoi();
            frmUocBoi.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSecurity_Click(object sender, EventArgs e)
        {
            Form formSecurity = new frmSecurity();
            formSecurity.Show();
        }
    }
}
