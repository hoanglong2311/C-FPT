namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a singleton object

            Thread t1 = new Thread(() => OngDevSingleTon.GetInstance().SayHi());
            Thread t2 = new Thread(() => OngDevSingleTon.GetInstance().SayHi());


            t1.Start();
            t2.Start();
        }

    }
}