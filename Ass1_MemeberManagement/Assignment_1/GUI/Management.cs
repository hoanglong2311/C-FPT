using BusinessLayer;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmManagement : Form
    {
        BindingSource source = new BindingSource();

        DataGridViewRow row;

        private IMemberRepository m_Repo = new MemberRepository();
        public IMemberRepository M_Repo { get => m_Repo; set => m_Repo = value; }
        public bool IsAdmin { get; set; }
        public Member MemberInfo { get; set; }

        public frmManagement()
        {
            InitializeComponent();
        }

        private void frmManagement_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = !IsAdmin;
            txtEmail.ReadOnly = !IsAdmin;
            btnAdd.Enabled = IsAdmin;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            grbMembers.Enabled = IsAdmin;

            if (IsAdmin)
            {
                load(M_Repo.GetMembers());
            }
            else
            {
                txtID.Text = MemberInfo.MemberID.ToString();
                txtName.Text = MemberInfo.MemberName;
                txtEmail.Text = MemberInfo.Email;
                txtPassword.Text = MemberInfo.Password;
                cboCountry.Text = MemberInfo.Country;
                cboCity.Text = MemberInfo.City;     
            }
        }

        public void load(IEnumerable<Member> list)
        {
            var members = list;
            try
            {
                source.DataSource = members;

                dgvMembers.DataSource = null;
                dgvMembers.DataSource = source;
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string err = isEmpty();
            if (err.Equals(""))
            {
                try
                {
                    M_Repo.Add(new Member(
                        int.Parse(txtID.Text),
                        txtName.Text,
                        txtEmail.Text,
                        txtPassword.Text,
                        cboCity.Text,
                        cboCountry.Text));

                    load(M_Repo.GetMembers());

                    row = null;

                    txtID.ReadOnly = false;
                    txtEmail.ReadOnly = false;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;

                    txtID.Text = string.Empty;
                    txtName.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    cboCountry.SelectedIndex = -1;
                    cboCity.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
            else
            {
                MessageBox.Show(err, "ERROR");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string err = isEmpty();
            if (err.Equals(""))
            {
                try
                {
                    M_Repo.Update(new Member(
                        int.Parse(txtID.Text),
                        txtName.Text,
                        txtEmail.Text,
                        txtPassword.Text,
                        cboCity.Text,
                        cboCountry.Text));

                    if (IsAdmin) load(M_Repo.GetMembers());

                    row = null;

                    txtID.ReadOnly = false;
                    txtEmail.ReadOnly = false;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;

                    txtID.Text = string.Empty;
                    txtName.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    cboCountry.SelectedIndex = -1;
                    cboCity.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
            else
            {
                MessageBox.Show(err, "ERROR");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                M_Repo.Delete(int.Parse(txtID.Text));

                load(M_Repo.GetMembers());

                row = null;

                txtID.ReadOnly = false;
                txtEmail.ReadOnly = false;

                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;

                txtID.Text = string.Empty;
                txtName.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
                cboCountry.SelectedIndex = -1;
                cboCity.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvMembers.SelectedRows[0];

            Member m = (Member)row.DataBoundItem;

            if(m != null)
            {
                txtID.Text = m.MemberID.ToString();
                txtName.Text = m.MemberName;
                txtEmail.Text = m.Email;
                txtPassword.Text = m.Password;
                cboCountry.Text = m.Country;
                cboCity.Text = m.City;

                txtID.ReadOnly = true;
                txtEmail.ReadOnly = true;

                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }        
        }

        private string isEmpty()
        {

            if (txtName.Text == "" || txtID.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                return "Empty Infomation!!";
            }

            return "";
        }
    }
}
