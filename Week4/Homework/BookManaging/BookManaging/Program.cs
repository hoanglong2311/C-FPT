using MyBookLibrary;

namespace BookManaging
{
    class Program
    {
        static void ShowMenu()
        {
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Remove a book");
            Console.WriteLine("3. Show all books");
            Console.WriteLine("4. Search a book");
            Console.WriteLine("5. Exit");
        }
        public static void Main(string[] args)
        {
            var a = new MyBookLibrary.BookList();
            int choice;

            do
            {
                ShowMenu();
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        // a.CreateList();
                        a.AddNewBook();
                        break;
                    case 2:
                        a.DeleteBook();
                        break;
                    case 3:
                        a.DisplayList();
                        break;
                    case 4:
                        a.SearchBook();
                        break;
                    case 5:
                        Console.WriteLine("Bye bye");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                
                
            } while (choice != 5);
        }
    }
}