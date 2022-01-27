namespace AccountManaging
{
    [Serializable]
    public class Account
    {
        private string accountID;
        private float balance;
        private string firstName;
        private string lastName;


        public Account() { }
        public Account(string accountID, string firstName, string lastName, float balance)
        {
            this.accountID = accountID;
            this.balance = balance;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public void FillInfo()
        {
            Console.WriteLine("Enter account ID: ");
            AccountID = Console.ReadLine();
            Console.WriteLine("Enter first name: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter balance: ");
            Balance = float.Parse(Console.ReadLine());
        }
        public void Query()
        {
            Console.WriteLine("Account ID: {0}", AccountID);
            Console.WriteLine("Balance: {0}", Balance);
            Console.WriteLine("First name: {0}", FirstName);
            Console.WriteLine("Last name: {0}", LastName);
        }

    }
}