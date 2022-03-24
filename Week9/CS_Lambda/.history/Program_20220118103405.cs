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
            string s = "ahihi";
            Action<string> action;

            action = (string s) => Console.WriteLine($"{s}"); //delegate void KIEU(string s) = Action<string>

        }
    }
}