using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformWithListBox
{
    public partial class Form1 : Form
    {
        List<string> myFriends = new List<string>();
        private BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            bs.DataSource = myFriends;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            myFriends.Add(txtNewFriend.Text);
            listBox1.DataSource = bs;
            bs.ResetBindings(false);
            label1.Text = "Total Friends: " + myFriends.Count;
        }
    }
}