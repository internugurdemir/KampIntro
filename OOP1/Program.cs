using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId=2;
            product1.ProductName="Masa";
            product1.UnitPrice=500;
            product1.UnitsInStock=3;

            Product product2 = new Product { Id = 2, CategoryId = 52, UnitsInStock = 120, ProductName = "Kalem", UnitPrice = 11 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            productManager.Toplama1(3,6);

            int sayi = 100;
            productManager.biseyYap(sayi);//100
            Console.WriteLine(sayi);

            productManager.Toplama2(5, 6);
            productManager.Toplama1(3, 1);

            int inttoplamsonucu = productManager.Toplama1(3,5);
            Console.WriteLine(sayi);
            Console.WriteLine(sayi);
            /*
             * 
             * int-double-bool... değer tip bu tiplerle değer yollandığında 100 değeri olarak gönderileri
             * 
             * diziler-classlar-arrayller referans bellek tutarak gider;
             * 
             */
            
            
        }
    }
}
