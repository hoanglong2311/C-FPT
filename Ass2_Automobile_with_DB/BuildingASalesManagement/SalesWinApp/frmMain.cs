using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        private static frmProducts? frmProduct;
        private static frmMembers? frmMember;
        private static frmOrders? frmOrder;

        public frmMain()
        {
            InitializeComponent();
        }

        private void memberManagementToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You can Create, Read, Update, Delete [Member] here.";
        }

        private void memberManagementToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void productManagementToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You can Create, Read, Update, Delete [Product] here.";
        }

        private void productManagementToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void orderManagementToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You can Create, Read, Update, Delete [Order] here.";
        }

        private void orderManagementToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void viewProductToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You can search for ProductId, ProductName, UnitsIntock, UnitPrice here.";
        }

        private void viewProductToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmMember == null || frmMember.FrmMemberState == false)
            {
                frmMember = new frmMembers { FrmMemberState = true };
                frmMember.AutoScroll = true;
                frmMember.TopLevel = false;
                frmMember.FormBorderStyle = FormBorderStyle.None;
                frmMember.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(frmMember);
                frmMember.BringToFront();

                if (frmProduct != null) frmProduct.FrmProuductState = false;
                if (frmOrder != null) frmOrder.FrmOrderState = false;
                frmMember.Show();
            }
        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmProduct == null || frmProduct.FrmProuductState == false)
            {
                frmProduct = new frmProducts {FrmProuductState = true};
                frmProduct.AutoScroll = true;
                frmProduct.TopLevel = false;
                frmProduct.FormBorderStyle = FormBorderStyle.None;
                frmProduct.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(frmProduct);
                frmProduct.BringToFront();

                if (frmMember != null) frmMember.FrmMemberState = false;
                if (frmOrder != null) frmOrder.FrmOrderState = false;
                frmProduct.Show();
            }
        }

        private void orderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOrder == null || frmOrder.FrmOrderState == false)
            {
                frmOrder = new frmOrders { FrmOrderState = true };
                frmOrder.AutoScroll = true;
                frmOrder.TopLevel = false;
                frmOrder.FormBorderStyle = FormBorderStyle.None;
                frmOrder.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(frmOrder);
                frmOrder.BringToFront();

                if (frmMember != null) frmMember.FrmMemberState = false;
                if (frmProduct != null) frmProduct.FrmProuductState = false;
                frmOrder.Show();
            }
        }

        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchProduct frmSearchProduct = new frmSearchProduct();
            frmSearchProduct.AutoScroll = true;
            frmSearchProduct.TopLevel = false;
            frmSearchProduct.FormBorderStyle = FormBorderStyle.None;
            frmSearchProduct.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(frmSearchProduct);
            frmSearchProduct.BringToFront();
            frmSearchProduct.Show();
        }
    }
}
