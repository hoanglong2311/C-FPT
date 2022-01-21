namespace Bai4
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICar tesla = new Tesla("Tesla", "Red", 100);
            ICar seat = new Seat("Seat", "Black");
            System.Console.WriteLine();
            Console.WriteLine(tesla.ToString());
            Console.WriteLine(seat.ToString());
        }
    }
}