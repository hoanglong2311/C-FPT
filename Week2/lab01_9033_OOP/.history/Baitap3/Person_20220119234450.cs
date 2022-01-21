namespace Baitap3
{
    public abstract class Person
    {
        public int Age { get; set; }
        public Boolean Gender { get; set; }

        protected Person() { }

        protected Person(int age, Boolean gender)
        {
            Age = age;
            Gender = gender;

        }

    }
}