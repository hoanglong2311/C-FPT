namespace CS_Delegate
{
    public delegate void ShowLog(string message);

    class Program
    {

        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info: {0}", s);
            Console.ResetColor();
        }
        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Info: {0}", s);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {

            ShowLog log = null;
            // log = Info;
            // log("Hello");
            // log.Invoke("Hello");

            // log = Warning;
            // log("warning");

            log += Info;
            log += Warning;
            log?.Invoke("Hello");


            Action action; //delegate void Kieu();
            Action<string> action1; //delegate void Kieu(string s); 
            Action<string, int> action2; //delegate void Kieu(string s, int i);

            action1 = Warning;
            action1 += Info;

            action1?.Invoke("Hello");
        }
    }
}