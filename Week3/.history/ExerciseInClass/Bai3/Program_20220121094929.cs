namespace Bai3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            List<Student> list = student.InputList();

            // list = student.SortList(list);
            var sortedList = list.OrderBy(x => x.Name);
            foreach (var item in sortedList)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}