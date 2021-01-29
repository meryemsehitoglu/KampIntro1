using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation prodcuttaki nesnenin tümünü yollamış oluyoruz product diyerek
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "elşendi.");
        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
    }
}
