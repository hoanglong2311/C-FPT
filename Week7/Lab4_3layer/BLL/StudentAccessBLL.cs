using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4_3layer.DAL;
using Lab4_3layer.DTO;

namespace Lab4_3layer.BLL
{
    internal class StudentAccessBLL
    {
        private StudentAccess StudentAccess = new StudentAccess();

        public List<Student> GetStudents()
        {
            return StudentAccess.GetStudents();
        }

        public bool InsertStudent(Student student)
        {
            if (StudentAccess.InsertStudent(student))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateStudent(Student student)
        {
            if (StudentAccess.UpdateStudent(student))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateStudent(string studentID)
        {
            if (StudentAccess.DeleteStudent(studentID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
