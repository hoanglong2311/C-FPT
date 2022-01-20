namespace Baitap4
{
    public class Manager : Person
    {
        public string Position { get; set; }
        public int WorkedDay { get; set; }

        public float Wage { get; set; }

        public Manager() { }

        public Manager(string name, int birthYear, string degree, string position, int workedDay, float wage)
            : base(name, birthYear, degree)
        {
            Position = position;
            WorkedDay = workedDay;
            Wage = wage;
        }

        public override float GetSalary()
        {
            return Wage * WorkedDay;
        }

        public override void Display()
        {
            System.Console.WriteLine("Manager: ");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("BirthYear: {0}", BirthYear);
            Console.WriteLine("Degree: {0}", Degree);
            Console.WriteLine("Position: {0}", Position);
            Console.WriteLine("WorkedDay: {0}", WorkedDay);
            Console.WriteLine("Wage: {0}", Wage);
        }

        public Manager InputData()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Birth year: ");
            BirthYear = int.Parse(Console.ReadLine());
            Console.Write("Enter Degree: ");
            Degree = Console.ReadLine();
            Console.Write("Enter Position: ");
            Position = Console.ReadLine();
            Console.Write("Enter WorkedDay: ");
            WorkedDay = int.Parse(Console.ReadLine());
            Console.Write("Enter Wage: ");
            Wage = float.Parse(Console.ReadLine());
            return new Manager(Name, BirthYear, Degree, Position, WorkedDay, Wage);
        }


    }
}