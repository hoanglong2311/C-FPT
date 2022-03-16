using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab04_3layer8th3.BLL;
using Lab04_3layer8th3.DTO;

namespace Lab04_3layer8th3.GUI
{
    public partial class frmCRUD : Form
    {
        public frmCRUD()
        {
            InitializeComponent();
        }
        StudentAccessBLL studentAccessBLL = new StudentAccessBLL();
        private void frmCRUD_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        public void LoadStudents()
        {
            List<Student> students = studentAccessBLL.GetStudents();
            BindingSource source = new BindingSource();
            foreach (var student in students)
            {
                source.Add(student);
            }

            dgvStudents.DataSource = source;
        }
        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            txtStudentID.Text = dgvStudents.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvStudents.CurrentRow.Cells[1].Value.ToString();
            txtClassID.Text = dgvStudents.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (studentAccessBLL.InsertStudent(new Student(txtStudentID.Text, txtName.Text, txtClassID.Text)))
            {
                LoadStudents();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (studentAccessBLL.UpdateStudent(new Student(txtStudentID.Text, txtName.Text, txtClassID.Text)))
            {
                LoadStudents();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (studentAccessBLL.DeleteStudent(txtStudentID.Text))
            {
                LoadStudents();
            }
        }
    }
}
