namespace Excersie2
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog() { }

        public Dog(string breed)
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }

        public override void Information()
        {
            Type = "Mammal";
            System.Console.WriteLine("Type: {0}", Type);
            System.Console.WriteLine("Breed: {0}", Breed);
            
        }

    }
}