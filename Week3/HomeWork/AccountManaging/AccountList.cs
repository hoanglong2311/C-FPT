using System.Collections;
namespace AccountManaging
{
    public class AccountList
    {
        private ArrayList accounts;

        public AccountList()
        {
            accounts = new ArrayList();
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
                    accounts.Add(new Account(tokens[0], tokens[2], tokens[3], float.Parse(tokens[1])));
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
    }
}