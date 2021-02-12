using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsintermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, boolean value types

            int sayi1 = 10;

            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine("Sayı 1 : " + sayi1);

            //arrays, class, interface... reference types

            int[] sayilari = new int[] { 1, 2, 3 }; int[] sayilar2 = new int[] { 18, 20, 30 };

            sayilari = sayilar2; sayilar2[0] = 1800;

            Console.WriteLine("Sayılari[0] = " + sayilari[0]);
        }
    }
}
