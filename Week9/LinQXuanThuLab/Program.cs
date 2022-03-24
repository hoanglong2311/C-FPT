namespace LinQXuanThuLab
{
    class Program
    {

        // public static void ProductPrice500()
        // {
        //     var res = from product in products
        //               where product.Price == 400
        //               select product;
        //     foreach (var product in res)
        //         System.Console.WriteLine(product.ToString());
        // }


        public static void CreateData()
        {
            var brands = new List<Brand>() {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 4, Name = "Công ty CCC"},
            };

            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };

            var res = from product in products
                      where product.Price == 400
                      select product;

            var kq = products.Select(
                (p) =>
                {
                    return new
                    {
                        name = p.Name,
                        price = p.Price,
                    };
                }
            );

            // foreach (var product in res)
            //     System.Console.WriteLine(product.ToString());


            foreach (var item in kq)
            {
                Console.WriteLine(item);
            }
        }


        public static void Main(string[] args)
        {
            CreateData();
        }






    }
}