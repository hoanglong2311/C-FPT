using BusinessLayer;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {

        IMemberRepository mRepo = new MemberRepository();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtLoginEmail.Text;
            string pass = txtLoginPassword.Text;

            if (email.Equals("admin") && pass.Equals("admin"))
            {
                frmManagement management = new frmManagement()
                {
                    IsAdmin = true,
                    M_Repo = mRepo
                };
                management.Show();
            }
            else
            {
                Member m = mRepo.Login(email, pass);
                if (m == null)
                {
                    MessageBox.Show("ERROR", "Member did not exist!");
                }
                else
                {
                    frmManagement management = new frmManagement()
                    {
                        IsAdmin = false,
                        M_Repo = mRepo,
                        MemberInfo = m
                    };
                    management.Show();
                }
            }
        }
    }
}
