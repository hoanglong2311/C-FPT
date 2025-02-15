﻿namespace AccountManaging
{

    public class Program
    {
        public static void ShowMenu()
        {
            Console.WriteLine("1. Add account");
            Console.WriteLine("2. Save file");
            Console.WriteLine("3. Load file");
            Console.WriteLine("4. Report");
            Console.WriteLine("5. Save File with BinaryFormatter");
            Console.WriteLine("6. Load File with BinaryFormatter");
            Console.WriteLine("7. Sort List");
            Console.WriteLine("8. Exit");
        }
        public static void Main(string[] args)
        {
            AccountList accountList = new AccountList();
            int choice;
            do
            {
                ShowMenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Account account = new Account();
                        account.FillInfo();
                        accountList.AddAccount(account);
                        break;
                    case 2:
                        accountList.SaveFile();
                        break;
                    case 3:
                        accountList.LoadFile();
                        break;
                    case 4:
                        accountList.Report();
                        break;
                    case 5:
                        accountList.SaveFileWithSerialization();
                        break;
                    case 6:
                        accountList.LoadFileWithSerialization();
                        break;
                    case 7:
                        accountList.SortList();
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 8);

        }
    }
}