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

            action?.Invoke("Hello", 10);
        }
    }
}