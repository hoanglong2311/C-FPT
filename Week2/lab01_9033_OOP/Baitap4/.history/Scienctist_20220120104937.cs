namespace Baitap4
{
    public class Scienctist : Person
    {
        public int PublicNews { get; set; }

        public int WorkedDay { get; set; }

        public float Wage { get; set; }

        public Scienctist() { }

        public Scienctist(string name, int birthYear, string degree, int publicNews, int workedDay, float wage)
            : base(name, birthYear, degree)
        {
            PublicNews = publicNews;
            WorkedDay = workedDay;
            Wage = wage;
        }

        public override float GetSalary()
        {
            return Wage * WorkedDay;
        }

        public override void Display()
        {
            System.Console.WriteLine("Scienctist: ");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("BirthYear: {0}", BirthYear);
            Console.WriteLine("Degree: {0}", Degree);
            Console.WriteLine("PublicNews: {0}", PublicNews);
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
            Console.Write("Enter PublicNews: ");
            PublicNews = int.Parse(Console.ReadLine());
            Console.Write("Enter WorkedDay: ");
            WorkedDay = int.Parse(Console.ReadLine());
            Console.Write("Enter Wage: ");
            Wage = float.Parse(Console.ReadLine());
            return new Manager(Name, BirthYear, Degree, PublicNews, WorkedDay, Wage);
        }
    }
}