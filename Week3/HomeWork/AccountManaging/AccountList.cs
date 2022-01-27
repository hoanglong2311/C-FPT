using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace AccountManaging
{
    public class AccountList
    {
        private List<Account> accounts = new List<Account>();

        public AccountList()
        {
            accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public void SaveFile()
        {
            //nhap ten file
            Console.WriteLine("Enter file name: ");
            string fileName = Console.ReadLine();
            //doc file
            try
            {
                //tao luong truy cap file
                FileStream output = new FileStream(fileName, FileMode.Create, FileAccess.Write);

                //thiet lap writer
                StreamWriter writer = new StreamWriter(output);

                //duyet qua tung account

                foreach (Account account in accounts)
                {
                    //ghi ra file
                    writer.WriteLine("{0},{1},{2},{3}", account.AccountID, account.FirstName, account.LastName, account.Balance);
                }
                //dong writer
                writer.Close();
                output.Close();
            }
            catch (IOException ex)
            {
                // TODO
                Console.WriteLine($"e.Message: {ex.Message}");

            }
        }

        public void LoadFile()
        {
            //doc ten file chua du lieu
            Console.WriteLine("Enter file name: ");
            string fileName = Console.ReadLine();
            //xoa danh sach
            accounts.Clear();
            //doc file
            try
            {
                //tao luong truy cap file
                FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                //thiet lap reader
                StreamReader reader = new StreamReader(input);


                //doc file
                string line = reader.ReadLine();
                while (line != null)
                {
                    //tach chuoi
                    string[] tokens = line.Split(',');
                    //them vao danh sach
                    accounts.Add(new Account(tokens[0], tokens[1], tokens[2], float.Parse(tokens[3])));
                    //doc tiep
                    line = reader.ReadLine();
                }
                //dong reader
                reader.Close();
                input.Close();
            }
            catch (IOException ex)
            {
                // TODO
                Console.WriteLine($"e.Message: {ex.Message}");
            }

        }

        public void Report()
        {
            foreach (Account item in accounts)
            {
                item.Query();
            }
        }

        public void SortList()
        {
            accounts = accounts.OrderBy(x => x.AccountID).ThenBy(x => x.FirstName).ThenBy(x => x.Balance).ToList();
        }


        public void SaveFileWithSerialization()
        {
            //nhap ten file
            Console.WriteLine("Enter file name: ");
            string fileName = Console.ReadLine();
            //doc file
            try
            {
                //tao luong truy cap file
                FileStream output = new FileStream(fileName, FileMode.Create, FileAccess.Write);

                //thiet lap writer
                BinaryFormatter writer = new BinaryFormatter();

                //ghi ra file
                writer.Serialize(output, accounts);
                //dong writer
                output.Close();
            }
            catch (IOException ex)
            {
                // TODO
                Console.WriteLine($"e.Message: {ex.Message}");

            }
        }

        public void LoadFileWithSerialization()
        {
            //doc ten file chua du lieu
            Console.WriteLine("Enter file name: ");
            string fileName = Console.ReadLine();
            //xoa danh sach
            accounts.Clear();
            //doc file
            try
            {
                //tao luong truy cap file
                FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                //thiet lap reader
                BinaryFormatter reader = new BinaryFormatter();

                //doc file
                accounts = (List<Account>)reader.Deserialize(input);
                //dong reader
                input.Close();
            }
            catch (IOException ex)
            {
                // TODO
                Console.WriteLine($"e.Message: {ex.Message}");
            }

        }
    }
}