namespace Baitap1
{
    class Tester
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter the number of students: ");
            int n = int.Parse(System.Console.ReadLine());

            Student[] students = new Student[n];

            System.Console.WriteLine("Input student information");
            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Id: ");
                int id = int.Parse(System.Console.ReadLine());
                System.Console.Write("Name: ");
                string name = System.Console.ReadLine();
                System.Console.Write("Faculty: ");
                string faculty = System.Console.ReadLine();
                System.Console.Write("Score: ");
                float score = float.Parse(System.Console.ReadLine());

                students[i] = new Student(id, name, faculty, score);
            }

            System.Console.WriteLine("Output student information");
            foreach (var item in students)
            {
                item.Show();
            }

        }
    }
}