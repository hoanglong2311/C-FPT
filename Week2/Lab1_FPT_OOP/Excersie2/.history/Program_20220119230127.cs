namespace Exersice2
{
    class Program
    {
        public static void ShowMenu()
        {
            Console.WriteLine("1. Duck");
            Console.WriteLine("2. Cat");
            Console.WriteLine("3. Dog");
            Console.WriteLine("4. Exit");
        }
        static void Main(string[] args)
        {

            int choice;
            do
            {
                ShowMenu();
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter swim: ");
                        string swim = Console.ReadLine();
                        Duck duck = new Duck(swim);
                        duck.Information();
                        break;
                    case 2:
                        Console.WriteLine("Enter climb: ");
                        string climb = Console.ReadLine();
                        Cat cat = new Cat(climb);
                        cat.Information();
                        break;
                    case 3:
                        Console.WriteLine("Enter breed: ");
                        string breed = Console.ReadLine();
                        Dog dog = new Dog(breed);
                        dog.Information();
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 4);

        }
    }
}
