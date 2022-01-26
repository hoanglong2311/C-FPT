using System.Collections;
namespace BookManaging
{
    public class BookList
    {

        //dinh nghia danh sach book
        private ArrayList list = new ArrayList();

        //tao mot doi tuong sach, nhap cac thong tin them vao list
        public void AddBook()
        {
            Book b = new Book();
            //nhap thong tin
            b.Input();
            //them vao danh sach
            list.Add(b);
        }

        //Xuat danh sach 
        public void ShowList()
        {
            foreach (Book b in list)
            {
                b.Show();
            }
        }


        //nhap danh sach

        public void InputList()
        {
            int n;
            Console.Write("Amount of book: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                AddBook();
                n--;
            }
        }

        public List<Book> GetSortedListByTitle()
        {
            return list.Cast<Book>().OrderBy(b => b.Title).ToList();
        }

    }
}