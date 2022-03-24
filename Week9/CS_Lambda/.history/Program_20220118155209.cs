namespace CS_Lambda
{

    // (các_tham_số) => biểu_thức;
    // (các_tham_số) =>
    //     {
    //     // các câu lệnh
    //         // Sử dụng return nếu có giá trị trả về
    //     }




    class Program
    {


        static void Main(string[] args)
        {

            Action<string> action;

            action = (string s) => Console.WriteLine($"{s.ToUpper()}"); //delegate void KIEU(string s) = Action<string>

            action?.Invoke("Hello");


            Func<int, int, int> calculate; // delegate int KIEU(int a, int b) = Func<int, int, int>
            calculate = (int a, int b) =>
            {
                int res = a + b;
                return res;
            };

            Console.WriteLine(calculate.Invoke(5, 6));



            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var kq = arr.Select((int x) =>
            {
                return Math.Sqrt(x);
            });

            foreach (var item in kq)
            {
                Console.WriteLine(item);
            }

        }
    }
}