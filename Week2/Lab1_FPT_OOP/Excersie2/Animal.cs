namespace Excersie2
{
    public abstract class Animal
    {
        public string Type { get; set; }

        protected Animal() { }
        public Animal(string type)
        {
            Type = type;
        }

        public abstract void MakeSound();
        public abstract void Information();

    }
}