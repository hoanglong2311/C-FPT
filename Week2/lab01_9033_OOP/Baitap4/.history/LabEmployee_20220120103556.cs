namespace Baitap4
{
    public class LabEmployee : Person
    {
        public float Salary { get; set; }

        public LabEmployee() { }

        public LabEmployee(string name, int birthYear, string degree, float Salary) : base(name, birthYear, degree)
        {
            this.Salary = Salary;
            this.Name = name;
            this.BirthYear = birthYear;
            this.Degree = degree;
        }

        public override float GetSalary()
        {
            return 0;
        }

        public override void Display()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("BirthYear: {0}", BirthYear);
            Console.WriteLine("Degree: {0}", Degree);
        }
    }
}