namespace Excersie2
{
    public class Cat : Animal
    {
        public string Climb { get; set; }

        public Cat() { }

        public Cat(string climb)
        {
            Climb = climb;
        }

        
    }
}