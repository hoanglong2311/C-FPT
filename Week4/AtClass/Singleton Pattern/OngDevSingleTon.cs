namespace Singleton_Pattern
{
    public class OngDevSingleTon
    {
        private int index;
        private static readonly object lockObject = new object(); // use to lock object
        private static volatile OngDevSingleTon uniqueInstance;//volatile keyword is used to ensure that the value of uniqueInstance is always up to date.
        private OngDevSingleTon(int index)
        {
            this.index = index;
        }

        public static OngDevSingleTon GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (lockObject)
                {
                    if (uniqueInstance == null)
                    {
                        var random = new Random();


                        uniqueInstance = new OngDevSingleTon(random.Next(1, 4));
                    }
                }
            }
            return uniqueInstance;
        }

        public void SayHi()
        {
            Console.WriteLine("Hi, I amOngdev num" + index);
        }
    }
}