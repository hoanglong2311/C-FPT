namespace Baitap4
{
    public class LabEmployee : Person
    {
        public float Salary { get; set; }

        public LabEmployee() { }

        public LabEmployee(string name, int birthYear, string degree, float salary)
            : base(name, birthYear, degree)
        {
            Salary = salary;
        }

        public LabEmployee InputData()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Birth year: ");
            BirthYear = int.Parse(Console.ReadLine());
            Console.Write("Enter Degree: ");
            Degree = Console.ReadLine();
            Console.Write("Enter month salary: ");
            Salary = float.Parse(Console.ReadLine());
            return new LabEmployee(Name, BirthYear, Degree, Salary);
        }
        public override float GetSalary()
        {
            return Salary;
        }

        public override void Display()
        {
            System.Console.WriteLine("Lab Employee: ");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("BirthYear: {0}", BirthYear);
            Console.WriteLine("Degree: {0}", Degree);
            Console.WriteLine("Salary: {0}", Salary);
        }
    }
}