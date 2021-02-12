using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            //product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName+" eklendi.");


        }
        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName+" güncellendi.");

        }
        public int Toplama1(int number1, int number2)
        {
            return number1 + number2;
        }
        public void Toplama2(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);

        }
        public void biseyYap(int sayi)
        {
            sayi = 99; //sayi burada 100 ama referans olmadığı için adresi olmadığı için aynı sayıyı yollmadı değiştirmedi

        }
    }
}
