namespace Baitap3
{
    public abstract class Person
    {
        public int Age { get; set; }
        public int Gender { get; set; }

        protected Person() { }

        protected Person(int age, bool gender)
        {
            Age = age;
            Gender = gender;

        }

    }
}