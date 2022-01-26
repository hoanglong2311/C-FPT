namespace BookManaging
{
    public interface IBook
    {
        //Mo ta indexer chuong sach
        string this[int index] { get; set; }

        //Property author dai dien cho ten cua tac gia cuon sach

        string Author { get; set; }

        //Publisher dai dien cho nha xuat ban cuon sach
        string Publisher { get; set; }

        string ISBN { get; set; }

        //Property Year : nam xuat ban cua cuon sach

        int Year { get; set; }

        //Mo ta phuong thuc hien thi cuon sach
        void Show();


    }
}