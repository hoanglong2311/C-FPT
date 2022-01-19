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
        

    }
}