using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE150191_PRACTICAL.DTO
{
    public class Book
    {
        public string BookID { set; get;}
        public string BookName { set; get; }
        public string Author { set; get; }
        public int PublicationYear { set; get; }

        public Book(string bookId, string bookName, string author, int publicationYear)
        {
            BookID = bookId;
            BookName = bookName;
            Author = author;
            PublicationYear = publicationYear;
        }
    }
}
