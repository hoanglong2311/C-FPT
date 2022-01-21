namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = InputList();
            NewSumList(list);
            Console.WriteLine("New list: ");
            foreach (int i in list)
            {
                Console.Write(" " + i);
            }
        }
        public static void NewSumList(List<int> list)
        {
            nt i = 0;
            int j = list.Count - 1;

            do
            {
                list[i] += list[j];
                list.RemoveAt(j);
                i++;
                j--;
            } while (i < list.Count - 1);
        }

        public static List<int> InputList()
        {
            List<int> list = new List<int>();
            int n;
            Console.Write("Enter number of elements: ");
            n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            return list;
        }
    }
}