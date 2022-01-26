using System.Collections;
using System;

namespace BookManaging
{
    public class Book : IBook
    {
        #region Dinh nghia du lieu
        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int year;




        //luu tru mang chua ten chuong
        private ArrayList chapters = new ArrayList();

        #endregion

        #region Thuc thi giao dien IBook

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chapters.Count)
                    return (string)chapters[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapters.Count)
                    chapters[index] = value; //Cap nhat lai chuong
                else if (index == chapters.Count)
                    chapters.Add(value); //Them chuong moi
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public string ISBN { get => isbn; set => isbn = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int Year { get => year; set => year = value; }

        public void Show()
        {
            //xuat thong tin sach ra man hinh
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Publisher: {publisher}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"ISBN: {isbn}");
            Console.WriteLine("Chapter: ");
            for (var i = 0; i < chapters.Count; i++)
            {
                Console.WriteLine($"t{i + 1}: {chapters[i]}");
            }
            Console.WriteLine("-----------------------");

        }

        public void Input()
        {
            //nhap thong tin sach
            Console.WriteLine("Nhap thong tin sach: ");
            Console.Write("Title: ");
            title = Console.ReadLine();
            Console.Write("Author: ");
            author = Console.ReadLine();
            Console.Write("Publisher: ");
            publisher = Console.ReadLine();
            Console.Write("ISBN: ");
            isbn = Console.ReadLine();
            Console.Write("Year: ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Input chapter (finisheed with empty string)");

            string str;
            do
            {
                str = Console.ReadLine();
                if (str != "")
                    chapters.Add(str);
            } while (str.Length > 0); //ket thuc khi chuoi rong

        }
        #endregion
    }
}