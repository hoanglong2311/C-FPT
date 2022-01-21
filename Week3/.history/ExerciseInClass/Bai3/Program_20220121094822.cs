namespace Bai3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            List<Student> list = student.InputList();

            // list = student.SortList(list);

            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}