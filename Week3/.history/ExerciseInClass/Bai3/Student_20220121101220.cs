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

        public override string ToString()
        {
            return $"{Id} - {Name} - {Age}";
        }

        public int CompareTo(Student other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public List<Student> InputList()
        {
            List<Student> list = new List<Student>();
            int n;
            Console.Write("Enter number of elements: ");
            n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter element {i}");
                Console.Write("Enter id: ");
                string id = Console.ReadLine();
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());
                list.Add(new Student(id, name, age));
            }
            return list;
        }

        public List<Student> SortList(List<Student> list)
        {
            list.Sort();
            return list;
        }
    }
}