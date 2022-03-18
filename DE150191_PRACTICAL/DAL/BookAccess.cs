using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DE150191_PRACTICAL.DTO;

namespace DE150191_PRACTICAL.DAL
{
    internal class BookAccess : DatabaseAccess
    {
        public bool UpdateBook(Book book)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command =
                new SqlCommand(
                    $"update Book set [BOOKNAME] ='{book.BookName}',[AUTHOR] ='{book.Author}' , [PUBLICATION_YEAR] ='{book.PublicationYear}' where [BOOK_ID] = '{book.BookID}'", connection);

            if (command.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public bool InsertBook(Book book)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "insert into Book values (@BookName,@Author,@PubYear)";
            SqlParameter parameter1 = new SqlParameter("@BookName", book.BookName);
            SqlParameter parameter2 = new SqlParameter("@Author", book.Author);
            SqlParameter parameter3 = new SqlParameter("@PubYear", book.PublicationYear);

            command.Parameters.Add(parameter1);
            command.Parameters.Add(parameter2);
            command.Parameters.Add(parameter3);

            if (command.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;
            }

            connection.Close();
            return false;
        }
        public bool DeleteBook(string bookID)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand($"Delete from BORROW where[BOOK_ID] = '{bookID}'\n" +
                                                $"Delete from Book where[BOOK_ID] = '{bookID}'", connection);
            //SqlCommand command = new SqlCommand($"Delete from Book where [BOOK_ID]='{bookID}'", connection);

            if (command.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;
            }

            connection.Close();
            return false;
        }

        public bool SearchBookByName(string bookName)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            ;

            SqlCommand command = new SqlCommand($"Select* from [BOOK] where [BOOKNAME] like '%{bookName}%", connection);

            if (command.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;
            }

            connection.Close();
            return false;
        }
    }
}
