namespace Baitap3
{
    public class Student : Person
    {
        public int Id { get; set; }
        public string SName { get; set; }
        public string SFaculty { get; set; }
        public float SScore { get; set; }

        List<Student> students;

        public Student() { }

        public Student(int id, string sname, string sfaculty, float sscore)
        {
            this.Id = id;
            this.SName = sname;
            this.SFaculty = sfaculty;
            this.SScore = sscore;
        }

        public Student(int id, string sname, string sfaculty, float sscore, int age, int gender) : base(age, gender)
        {
            this.Id = id;
            this.SName = sname;
            this.SFaculty = sfaculty;
            this.SScore = sscore;
            this.Age = age;
            this.Gender = gender;
        }


        public Student InputStudent()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Faculty: ");
            string faculty = Console.ReadLine();
            Console.Write("Score: ");
            float score = float.Parse(Console.ReadLine());
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Gender: ");
            int gender = int.Parse(Console.ReadLine());

            return new Student(id, name, faculty, score, age, gender);
        }

        public void InputList()
        {
            Console.Write("Enter the number of students: ");
            int n = int.Parse(Console.ReadLine());

            students = new List<Student>();

            Console.WriteLine("Input student information");
            for (int i = 0; i < n; i++)
            {
                students[i] = InputStudent();
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Output student information");
            foreach (var item in students)
            {
                item.Show();
            }
        }
        public void Show()
        {
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Name: {0}", this.SName);
            Console.WriteLine("Faculty: {0}", this.SFaculty);
            Console.WriteLine("Score: {0}", this.SScore);
        }


    }
}