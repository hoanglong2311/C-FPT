namespace Excersie2
{
    public class Duck : Animal
    {
        public string Swim { get; set; }
        public Duck () { }

        public Duck(string swim)
        {
            Swim = swim;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Quack!");
        }

        public override void Information()
        {
            Type = "Bird";
            System.Console.WriteLine("Type: {0}", Type);
            System.Console.WriteLine("Swim: {0}", Swim);
            MakeSound();
        }
        
    }
}