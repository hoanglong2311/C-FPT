namespace Bai3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> list = InputList();

            list = SortList(list);

            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}