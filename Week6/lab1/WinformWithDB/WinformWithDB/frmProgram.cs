using System;
using System.Windows.Forms;

namespace WinformWithDB
{
    public partial class frmProgram : Form
    {
        public frmProgram()
        {
            InitializeComponent();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form form = new frmQueryData();
            form.Show();
        }
    }
}