using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmSecurity : Form
    {
        private List<String> logAccess = new List<string>();
        private BindingSource bindingSource = new BindingSource();
        public frmSecurity()
        {
            InitializeComponent();
            bindingSource.DataSource = logAccess;
        }

        private void lbxAccessLog_Click(object sender, EventArgs e)
        {
            if (sender == btn0)
            {
                txtSecurityCode.Text += '0';
            }
            if (sender == btn1)
            {
                txtSecurityCode.Text += '1';
            }
            if (sender == btn2)
            {
                txtSecurityCode.Text += '2';
            }
            if (sender == btn3)
            {
                txtSecurityCode.Text += '3';
            }
            if (sender == btn4)
            {
                txtSecurityCode.Text += '4';
            }
            if (sender == btn5)
            {
                txtSecurityCode.Text += '5';
            }
            if (sender == btn6)
            {
                txtSecurityCode.Text += '6';
            }
            if (sender == btn7)
            {
                txtSecurityCode.Text += '7';
            }
            if (sender == btn8)
            {
                txtSecurityCode.Text += '8';
            }
            if (sender == btn9)
            {
                txtSecurityCode.Text += '9';
            }
        }

        private void btnSharp_Click(object sender, EventArgs e)
        {
            
            string securityCode = txtSecurityCode.Text;
            string status;
            switch (securityCode)
            {
                case "1645":
                    status = DateTime.Today.Date.ToString() + "    Technicians";
                    logAccess.Add(status);
                    lbxAccessLog.DataSource = bindingSource;
                    bindingSource.ResetBindings(false);
                    btnC_Click(sender,e);
                    break;
                case "1689":
                     status = DateTime.Today.Date.ToString() + "    Technicians";
                    logAccess.Add(status);
                    lbxAccessLog.DataSource = bindingSource;
                    bindingSource.ResetBindings(false);
                    btnC_Click(sender, e);
                     break;
                case "8345":
                    status = DateTime.Today.Date.ToString() + "    Custodians";
                    logAccess.Add(status);
                    lbxAccessLog.DataSource = bindingSource;
                    bindingSource.ResetBindings(false);
                    btnC_Click(sender, e);
                    break;
                case "9998":
                    status = DateTime.Today.Date.ToString() + "    Scientist";
                    logAccess.Add(status);
                    lbxAccessLog.DataSource = bindingSource;
                    bindingSource.ResetBindings(false);
                    btnC_Click(sender, e);
                    break;
                case "1006":
                    status = DateTime.Today.Date.ToString() + "    Scientist";
                    logAccess.Add(status);
                    lbxAccessLog.DataSource = bindingSource;
                    bindingSource.ResetBindings(false);
                    btnC_Click(sender, e);
                    break;
                case "1008":
                    status = DateTime.Today.Date.ToString() + "    Scientist";
                    logAccess.Add(status);
                    lbxAccessLog.DataSource = bindingSource;
                    bindingSource.ResetBindings(false);
                    btnC_Click(sender, e);
                    break;
                default:
                    status = DateTime.Today.Date.ToString() + "    Restricted Access!";
                    logAccess.Add(status);
                    lbxAccessLog.DataSource = bindingSource;
                    bindingSource.ResetBindings(false);
                    btnC_Click(sender, e);
                    break;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = String.Empty;
        }
    }
}
