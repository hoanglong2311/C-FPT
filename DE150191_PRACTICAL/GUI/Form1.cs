using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE150191_PRACTICAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void byBookNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchBookByName.GetInstance.MdiParent = this;
            frmSearchBookByName.GetInstance.Show();
            LibraryLabel.Hide();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateBook.GetInstance.MdiParent = this;
            frmUpdateBook.GetInstance.Show();
            LibraryLabel.Hide();

        }
    }
}
