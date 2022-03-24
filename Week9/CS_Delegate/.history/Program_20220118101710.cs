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

        static int Sum(int a, int b) => a + b;
        static int Sub(int a, int b) => a - b;

        static void Tong(int a, int b, ShowLog log)
        {
            int res = a + b;
            log?.Invoke($"{a} + {b} = {res}");
        }

        static void Main(string[] args)
        {

            ShowLog log = null;
            // log = Info;
            // log("Hello");
            // log.Invoke("Hello");

            // log = Warning;
            // log("warning");

            // log += Info;
            // log += Warning;
            // log?.Invoke("Hello");


            // Action action; //delegate void Kieu();
            // Action<string> action1; //delegate void Kieu(string s); 
            // Action<string, int> action2; //delegate void Kieu(string s, int i);

            // action1 = Warning;
            // action1 += Info;

            // action1?.Invoke("Hello");


            Func<int> f1; //delegate int Kieu(); => có kiểu trả về int
            Func<string, double, string> f2; // delegate string Kieu(string s, double d); => có kiểu trả về string


            Func<int, int, int> calculate;
            int a = 5;
            int b = 10;

            calculate = Sum;
            Console.WriteLine("Sum: {0}", calculate(a, b));


            Tong(a, b, Info);
        }
    }
}