using MyBookLibrary;

namespace BookManaging
{
    class Program
    {
        public static void Main(string[] args)
        {
            var a = new MyBookLibrary.BookList();
            a.CreateList();
            a.DisplayList();
            a.SearchBook();
        }
    }
}