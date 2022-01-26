namespace BookManaging
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BookList b = new BookList();
            b.InputList();
            b.ShowList();
            System.Console.WriteLine("--------------");
            Console.WriteLine("Sorted by title:");

            var sortedList = b.GetSortedListByTitle();

            foreach (var item in sortedList)
            {
                item.Show();
            }
        }
    }
}