namespace Exercise1
{


    class Program
    {

        public static void ShowMenu()
        {
            Console.WriteLine("1. Line");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Circle");
            Console.WriteLine("4. Polyline");
            Console.WriteLine("5. Quit");
        }
        static void Main(string[] args)
        {
            int choice;
            ShapeManagement sm = new ShapeManagement();
            do
            {
                ShowMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        sm.LineManagement();
                        break;
                    case 2:
                        sm.RectangleManagement();
                        break;
                    case 3:
                        sm.CircleManagement();
                        break;
                    case 4:
                        sm.PolyLineManagement();
                        break;
                    case 5:
                        System.Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }

            } while (choice != 5);
        }
    }
}
