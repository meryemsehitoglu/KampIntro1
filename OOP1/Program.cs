using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //Bu şekilde de yazabiliriz.
            Product product2 = new Product { Id = 5, CategoryId = 2, UnitsInStock = 5, UnitPrice = 35, ProductName = "Kalem" };

            //class        //isim
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}
