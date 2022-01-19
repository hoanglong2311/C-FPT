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
        
    }
}