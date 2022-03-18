using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DE150191_PRACTICAL.BLL;
using DE150191_PRACTICAL.DTO;

namespace DE150191_PRACTICAL
{
    public partial class frmUpdateBook : Form
    {
        public frmUpdateBook()
        {
            InitializeComponent();
        }

        private static frmUpdateBook instance;
        public static frmUpdateBook GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmUpdateBook();
                }
                return instance;
            }
        }

        private BookAccessBLL bookAccessBll = new BookAccessBLL();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bookAccessBll.DeleteBook(txtBookId.Text))
            {
                MessageBox.Show("Delete Successfully!");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Can not delete!");
                ClearTextBox();
            }
        }

        private void ClearTextBox()
        {
            txtAuthor.Text = String.Empty;
            txtBookId.Text = String.Empty;
            txtBookName.Text = String.Empty;
            txtYear.Text = String.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bookAccessBll.UpdateBook(new Book(txtBookId.Text, txtBookName.Text, txtAuthor.Text, Convert.ToInt32(txtYear.Text))))
            {
                MessageBox.Show("Update Successfully!");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Can not Update!");
                ClearTextBox();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (bookAccessBll.InsertBook(new Book(txtBookId.Text, txtBookName.Text, txtAuthor.Text, Convert.ToInt32(txtYear.Text))))
            {
                MessageBox.Show("Insert Successfully!");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Can not Insert!");
                ClearTextBox();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
