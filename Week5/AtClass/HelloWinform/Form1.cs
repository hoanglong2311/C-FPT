using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //set focus for txtNumber1
            txtNumber1.Focus();
            // txtNumber1.Select();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //quit program
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset the form
            this.txtNumber1.Text = "";
            this.txtNumber2.Text = "";
            this.txtNumber3.Text = "";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            try
            {
                a = double.Parse(txtNumber1.Text);
                b = double.Parse(txtNumber2.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please enter a valid number" + exception.Message);
                throw;
            }
            double result = a + b;
            
            txtNumber3.Text = result.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void txtNumber3_TextChanged(object sender, EventArgs e)
        {
            //set readonly
            txtNumber3.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNumber2_KeyDown(object sender, KeyEventArgs e)
        {
            //if enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                btnSum_Click(sender, e);
            }else if (e.KeyCode == Keys.Tab)
            {
                button2_Click(sender, e);
            }else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)        
            {
                btnSum_Click(sender,e);
            }else if (e.KeyCode == Keys.Tab)
            {
                button2_Click(sender, e);
            }
        }
    }
}