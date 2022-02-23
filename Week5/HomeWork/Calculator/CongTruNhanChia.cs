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
    public partial class CongTruNhanChia : Form
    {
        public CongTruNhanChia()
        {
            InitializeComponent();
        }

        private int TinhTong(int n, int m) => m + n;
        private int TinhTru(int n, int m) => n - m;
        private int TinhNhan(int n, int m) => n * m;
        private float TinhChia(float n, float m) => n / m;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNumberN.Text);
            int m = int.Parse(txtNumberM.Text);
            txtResult.Text = TinhTong(m, n).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

            int n = int.Parse(txtNumberN.Text);
            int m = int.Parse(txtNumberM.Text);
            txtResult.Text = TinhTru(n, m).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNumberN.Text);
            int m = int.Parse(txtNumberM.Text);
            txtResult.Text = TinhNhan(m, n).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtNumberN.Text);
            float m = float.Parse(txtNumberM.Text);
            txtResult.Text = TinhChia(n, m).ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            txtNumberM.Text = String.Empty;
            txtNumberN.Text = String.Empty;
            txtResult.Text = String.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
