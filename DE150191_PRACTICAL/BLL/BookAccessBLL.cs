using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DE150191_PRACTICAL.DAL;
using DE150191_PRACTICAL.DTO;

namespace DE150191_PRACTICAL.BLL
{
    internal class BookAccessBLL
    {
        private BookAccess bookAccess = new BookAccess();

        public bool InsertBook(Book book)
        {
            if (bookAccess.InsertBook(book))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateBook(Book book)
        {
            if (bookAccess.UpdateBook(book))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteBook(string bookID)
        {
            if (bookAccess.DeleteBook(bookID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SearchBook(string booknName)
        {
            if (bookAccess.SearchBookByName(booknName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
