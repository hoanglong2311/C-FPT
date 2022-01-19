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

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
         
        public override void Information()
        {
            Type = "Mammal";
            System.Console.WriteLine("Type: {0}", Type);
            System.Console.WriteLine("Climb: {0}", Climb);
            MakeSound();
        }
        
    }
}