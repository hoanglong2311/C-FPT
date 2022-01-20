namespace Baitap4
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Degree { get; set; }

        protected Person() { }

        public Person(string name, int birthYear, string degree)
        {
            Name = name;
            BirthYear = birthYear;
            Degree = degree;
        }

        public abstract float GetSalary();
        public abstract void Display();
    }
}