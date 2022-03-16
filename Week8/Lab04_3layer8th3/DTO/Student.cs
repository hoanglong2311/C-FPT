using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_3layer8th3.DTO
{
    internal class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string ClassID { get; set; }

        public Student(string id, string name, string classId)
        {
            ID = id;
            Name = name;
            ClassID = classId;
        }
    }
}
