using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBunifu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(panel1);
            bunifuFormDock1.SubscribeControlToDragEvents(panel2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control) sender).Top;
            bunifuPages1.SetPage(Dashboardpage);

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages1.SetPage(Activitypage);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages1.SetPage(Projectpage);
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages1.SetPage(Inboxpage);

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages1.SetPage(Contactpage);

        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages1.SetPage(Aboutpage);
        }

    }
}
