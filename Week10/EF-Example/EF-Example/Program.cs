using EF_Example.Entities;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
       
        Console.ReadKey();
    }

    public static void CreateDatabase()
    {
        using var dbContext = new DBProductManagement();

        string dbName = dbContext.Database.GetDbConnection().Database;
        Console.WriteLine(dbName);
        bool result = dbContext.Database.EnsureCreated();

        if (result) Console.WriteLine("Created");
        else Console.WriteLine("Failed");
    }

    public static void InsertProduct()
    {
        using var dbContext = new DBProductManagement();
        var product = new Product();

        product.Name = "Product 1";
        product.Provider = "provider1";

        dbContext.Products.Add(product);
        int result = dbContext.SaveChanges();
        Console.WriteLine(result);
    }

    public static void DeleteProduct(int id)
    {
        using var dbContext = new DBProductManagement();
        Product product = dbContext.Products.Where(x => x.Id == id).First();
        dbContext.Products.Remove(product);
        dbContext.SaveChanges();
    }

    public static void UpdateProduct(Product p)
    {
        using var dbContext = new DBProductManagement();
        Product product = dbContext.Products.Where(x => x.Id == p.Id).First();
        product.Name = p.Name;
        product.Provider = p.Provider;
        dbContext.Products.Update(product);
        dbContext.SaveChanges();
    }

    public static void GetProductById(int id)
    {
        using var dbContext = new DBProductManagement();
        var products = dbContext.Products.Where(p => p.Id == id).ToList();
        products.ForEach(p => p.Info());
    }

    public static void GetProducts()
    {
        using var dbContext = new DBProductManagement();
        var products = dbContext.Products.ToList();  
        products.ForEach(p => p.Info());
    }

    public static void DeleteDatabase()
    {
        using var dbContext = new DBProductManagement();

        string dbName = dbContext.Database.GetDbConnection().Database;
        Console.WriteLine(dbName);
        bool result = dbContext.Database.EnsureDeleted();

        if (result) Console.WriteLine("Deleted");
        else Console.WriteLine("Failed");
    }
}