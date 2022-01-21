using System.Collections.Generic;
namespace Bai1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            List<int> list = InputList();
            NewSumList(list);
            Console.WriteLine("New list: ");
            foreach (int i in list)
            {
                Console.Write(" " + i);
            }

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

        public static void NewSumList(List<int> list)
        {
            int i = 0;
            List<int> newList = new List<int>();
            do
            {
                if (list[i] == list[i + 1])
                {
                    list[i] = list[i] + list[i + 1];
                    list.RemoveAt(i + 1);
                    // newList.Add(list[i]);
                    i = 0;
                }
                else i++;
            } while (i < list.Count - 1);
        }


    }
}