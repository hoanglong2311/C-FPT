using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFerhenheight_Click(object sender, EventArgs e)
        {
           ConvertFerhenheight(sender,e);
            
        }
        
        private void ConvertFerhenheight(object sender, EventArgs e)
        {
            float f;

            try
            {
                f = float.Parse(txtFerhenheight.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please enter a number");
                throw;
            }
            float c = (f - 32) * 5f / 9f;
            double k = (f + 459.67) * 5f / 9f;

            txtCelsius.Text = c.ToString();
            txtKelvin.Text = k.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = "";
            txtKelvin.Text = "";
            txtFerhenheight.Text = "";
        }

        private void btnCelcius_Click(object sender, EventArgs e)
        {
            float c;
            try
            {
                c = float.Parse(txtCelsius.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please enter a number");
                throw;
            }
            float f = (c * 9f / 5f) + 32;
            double k = c + 273.15;
            txtFerhenheight.Text = f.ToString();
            txtKelvin.Text = k.ToString();
        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            double k;
            try
            {
                k = double.Parse(txtKelvin.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please enter a number");
                throw;
            }
            double c = k - 273.15;
            float f = (float)((k - 459.67) * 9f / 5f);
            txtCelsius.Text = c.ToString();
            txtFerhenheight.Text = f.ToString();
        }

        private void txtFerhenheight_TextChanged(object sender, EventArgs e)
        {
            ConvertFerhenheight(sender, e);
        }
    }
}