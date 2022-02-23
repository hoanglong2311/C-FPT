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
    public partial class frmUocBoi : Form
    {
        public frmUocBoi()
        {
            InitializeComponent();
        }

        public int CalUSCLN(int n1, int n2)
        {
            int uscln = 1;
            int j = (n1 < n2) ? n1 : n2;
            for (int i = 1; i <= j; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    uscln = i;
                }
            }

            return uscln;
        }


        public int CalBSCNN(int n1, int n2)
        {
            int uscln = CalUSCLN(n1, n2);
            return (n1 * n2) / uscln;
        }


        private void rdUscln_CheckedChanged(object sender, EventArgs e)
        {
            
            int a = int.Parse(txtNumberA.Text);
            int b = int.Parse(txtNumberB.Text);
            if (rdUscln.Checked ==true)
            {
                
                txtKetQua.Text = string.Empty;
                txtKetQua.Text = CalUSCLN(a, b).ToString();
            }
            else
            {
                txtKetQua.Text = string.Empty;
                txtKetQua.Text = CalBSCNN(a, b).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNumberA.Text = String.Empty;
            txtNumberB.Text = String.Empty;
            txtKetQua.Text = String.Empty;
            rdUscln.Checked = false;
            rdBscnn.Checked = false;
        }

    }
}
