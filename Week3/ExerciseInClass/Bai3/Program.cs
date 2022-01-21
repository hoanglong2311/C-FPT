namespace Bai3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            List<Student> list = student.InputList();

            // list = student.SortList(list);
            var sortedList = list.OrderBy(x => x.Name); // x.Name is the property name of Student class, I use LINQ to sort the list by Name
            foreach (var item in sortedList)
            {
                System.Console.WriteLine("List after sorting by name: ");
                System.Console.WriteLine(item);
            }
        }
    }
}