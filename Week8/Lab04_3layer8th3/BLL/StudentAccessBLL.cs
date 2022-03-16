using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab04_3layer8th3.DAL;
using Lab04_3layer8th3.DTO;

namespace Lab04_3layer8th3.BLL
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
        public bool DeleteStudent(string studentID)
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
