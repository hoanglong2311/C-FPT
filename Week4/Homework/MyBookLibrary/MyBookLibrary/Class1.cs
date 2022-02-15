namespace MyBookLibrary;


public class Book
{
    public string ID { get; set; }
    public string name { get; set; }
    public string publisher { get; set; }
    public float price { get; set; }

    public Book()
    {
    }

    public Book(string id, string name, string publisher, float price)
    {
        ID = id;
        this.name = name;
        this.publisher = publisher;
        this.price = price;
    }
}
public class BookList
{
    public List<Book> ListOfBooks = new List<Book>();

    public int GetNumberOfBooks()
    {
        int numberOfBooks;
        Console.WriteLine("Enter the number of books you want to add to the list: ");
        while (!int.TryParse(Console.ReadLine(), out numberOfBooks))
        {
            Console.WriteLine("Please enter a valid number: ");
        }
        return numberOfBooks;
    }
    
    public List<Book> CreateList()
    {
        int numberOfBooks = GetNumberOfBooks();
        for (int i = 0; i < numberOfBooks; i++)
        {
            Console.WriteLine("Enter the ID of the book: ");
            string id = Console.ReadLine();
            while (!id.All(char.IsLetterOrDigit))
            {
                Console.WriteLine("Please enter a valid ID: ");
                id = Console.ReadLine();
            }
            
            Console.WriteLine("Enter the name of the book: ");
            string name = Console.ReadLine();
            while (!name.All(char.IsLetterOrDigit))
            {
                Console.WriteLine("Please enter a valid name: ");
                name = Console.ReadLine();
            }
            
            Console.WriteLine("Enter the publisher of the book: ");
            string publisher = Console.ReadLine();
            while (!publisher.All(char.IsLetterOrDigit))
            {
                Console.WriteLine("Please enter a valid publisher: ");
                publisher = Console.ReadLine();
            }
            
            Console.WriteLine("Enter the price of the book: ");
            float price;
            while (!float.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Please enter a valid number: ");
            }
            Book book = new Book(id, name, publisher, price);
            ListOfBooks.Add(book);
        }
        return ListOfBooks;
    }
    
    
    public void DisplayList()
    {
        foreach (Book book in ListOfBooks)
        {
            Console.WriteLine("ID: " + book.ID + " Name: " + book.name + " Publisher: " + book.publisher + " Price: " + book.price);
        }
    }
    
    public void SearchBook()
    {
        Console.WriteLine("Enter the ID of the book you want to search: ");
        string id = Console.ReadLine();
        foreach (Book book in ListOfBooks)
        {
            if (book.ID == id)
            {
                Console.WriteLine("ID: " + book.ID + " Name: " + book.name + " Publisher: " + book.publisher + " Price: " + book.price);
            }
        }
    }

    public void DisplayBookByID(string id)
    {
        foreach (var book in ListOfBooks)
        {
            if (book.ID == id)
            {
                Console.WriteLine("ID: " + book.ID + " Name: " + book.name + " Publisher: " + book.publisher + " Price: " + book.price);
            }
        }
    }
    public void DeleteBook()
    {
        Console.WriteLine("Enter the ID of the book you want to delete: ");
        string id = Console.ReadLine();
        foreach (Book book in ListOfBooks)
        {
            if (book.ID == id)
            {
                ListOfBooks.Remove(book);
            }
        }
    }
    public void UpdateBook()
    {
        Console.WriteLine("Enter the ID of the book you want to update: ");
        string id = Console.ReadLine();
        foreach (var book in ListOfBooks)
        {
            if (book.ID.Equals(id))
            {
                Console.WriteLine("The old data of the book is: ");
                DisplayBookByID(id);
                Console.WriteLine("Enter the new data of the book: ");
                Console.WriteLine("Enter the ID of the book: ");
                string newID = Console.ReadLine();
                while (!newID.All(char.IsLetterOrDigit))
                {
                    Console.WriteLine("Please enter a valid ID: ");
                    newID = Console.ReadLine();
                }
                
                Console.WriteLine("Enter the name of the book: ");
                string newName = Console.ReadLine();
                while (!newName.All(char.IsLetterOrDigit))
                {
                    Console.WriteLine("Please enter a valid name: ");
                    newName = Console.ReadLine();
                }
                
                Console.WriteLine("Enter the publisher of the book: ");
                string newPublisher = Console.ReadLine();
                while (!newPublisher.All(string.IsLetterOrDigit))
                {
                    Console.WriteLine("Please enter a valid publisher: ");
                    newPublisher = Console.ReadLine();
                }
                
                Console.WriteLine("Enter the price of the book: ");
                float newPrice;
                while (!float.TryParse(Console.ReadLine(), out newPrice))
                {
                    Console.WriteLine("Please enter a valid number: ");
                }
            }
        }
    }
    
    public void SortByPrice()
    {
        ListOfBooks.Sort((x, y) => x.price.CompareTo(y.price));
    }
    
    public void SortByName()
    {
        ListOfBooks.Sort((x, y) => x.name.CompareTo(y.name));
    }
    
    public void SortByPublisher()
    {
        ListOfBooks.Sort((x, y) => x.publisher.CompareTo(y.publisher));
    }
    
    public void SortByID()
    {
        ListOfBooks.Sort((x, y) => x.ID.CompareTo(y.ID));
    }

    
    
}