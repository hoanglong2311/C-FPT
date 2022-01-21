namespace Bai3
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student() { }

        public Student(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

    }
}