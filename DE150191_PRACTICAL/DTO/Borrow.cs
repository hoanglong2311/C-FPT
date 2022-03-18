using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DE150191_PRACTICAL.DTO
{
    internal class Borrow
    {
        public string BorrowerID { set; get; }

        public string BookID { set; get; }

        public DateTime BorroworDate { set; get; }
        public DateTime ReturnDate { set; get; }

        public Borrow(string borrowerId, string bookId, string borroworDate, string returnDate)
        {
            BorrowerID = borrowerId;
            BookID = bookId;
            BorroworDate = DateTime.Parse(borroworDate);
            ReturnDate = DateTime.Parse(returnDate);
        }
    }
}
