namespace Baitap4
{
    public class Program
    {

        public static void ShowMenu()
        {
            Console.WriteLine("1. Add new employee");
            Console.WriteLine("2. Display all employee");
            Console.WriteLine("3. Exit");
        }

        public static void AddEmployee(List<Person> listPerson)
        {
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Scienctist");
            Console.WriteLine("3. LabEmployee");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Manager manager = new Manager();
                    manager = manager.InputData();
                    listPerson.Add(manager);
                    // manager.Display();
                    break;
                case 2:
                    Scienctist scienctist = new Scienctist();
                    scienctist = scienctist.InputData();
                    listPerson.Add(scienctist);
                    // scienctist.Display();
                    break;
                case 3:
                    LabEmployee labEmployee = new LabEmployee();
                    labEmployee = labEmployee.InputData();
                    listPerson.Add(labEmployee);
                    // labEmployee.Display();
                    break;
                default:
                    break;
            }
        }

        public static void DisplayEmployee(List<Person> listPerson)
        {
            foreach (var item in listPerson)
            {
                item.Display();
            }
        }

        public static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();

            while (true)
            {
                ShowMenu();
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddEmployee(listPerson);
                        break;
                    case 2:
                        DisplayEmployee(listPerson);
                        break;
                    case 3:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}