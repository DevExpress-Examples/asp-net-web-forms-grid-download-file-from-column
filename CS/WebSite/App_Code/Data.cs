using System.Collections.Generic;

public class Product {
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public decimal? UnitPrice { get; set; }
    public short? UnitsOnOrder { get; set; }
    public string ImagePath { get; set; }

    public static List<Product> GetData() {
        List<Product> products = new List<Product>();

        products.Add(new Product() { ProductID = 1, ProductName = "Chai", UnitPrice = 19, UnitsOnOrder = 0, ImagePath = "~/Images/IMG_1321.jpg" });
        products.Add(new Product() { ProductID = 2, ProductName = "Chang", UnitPrice = 19, UnitsOnOrder = 40 });
        products.Add(new Product() { ProductID = 3, ProductName = "Aniseed Syrup", UnitPrice = 10, UnitsOnOrder = 70, ImagePath = "~/Images/IMG_1397.jpg" });

        products.Add(new Product() { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", UnitPrice = 22, UnitsOnOrder = 0 });
        products.Add(new Product() { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", UnitPrice = 21.35m, UnitsOnOrder = 0, ImagePath = "~/Images/IMG_1407.jpg" });
        products.Add(new Product() { ProductID = 6, ProductName = "Grandma's Boysenberry Spread", UnitPrice = 25, UnitsOnOrder = 0, ImagePath = "~/Images/IMG_1409.jpg" });

        products.Add(new Product() { ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", UnitPrice = 30, UnitsOnOrder = 0, ImagePath = "~/Images/IMG_1445.jpg" });
        products.Add(new Product() { ProductID = 8, ProductName = "Northwoods Cranberry Sauce", UnitPrice = 40, UnitsOnOrder = 0 });
        products.Add(new Product() { ProductID = 9, ProductName = "Mishi Kobe Niku", UnitPrice = 97, UnitsOnOrder = 0, ImagePath = "~/Images/IMG_1391.jpg" });

        products.Add(new Product() { ProductID = 10, ProductName = "Ikura", UnitPrice = 31, UnitsOnOrder = 0 });
        products.Add(new Product() { ProductID = 11, ProductName = "Queso Cabrales", UnitPrice = 21, UnitsOnOrder = 30, ImagePath = "~/Images/IMG_1403.jpg" });
        products.Add(new Product() { ProductID = 12, ProductName = "Queso Manchego La Pastora", UnitPrice = 38, UnitsOnOrder = 0 });

        return products;
    }
}