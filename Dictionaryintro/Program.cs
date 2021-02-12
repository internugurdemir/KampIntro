using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaryintro
{
    class Program
    {
        class Araba
        {
            public string Marka { get; set; }
            public string Model { get; set; }
            public string Renk { get; set; }
            public int Fiyat { get; set; }
        }

        public static void Main()
        {
            var cars = new Dictionary<int, Araba>()
        {
            { 100, new Araba { Marka="Citroen", Model="C3",     Renk="Bej", Fiyat=170000 } },
            { 101, new Araba { Marka="Mercedes", Model="A 180", Renk="Kırmızı", Fiyat=457000 } },
            { 102, new Araba { Marka="Renault", Model="Clio", Renk="Füme", Fiyat=127000 } },
            { 103, new Araba { Marka="BMW", Model="M5", Renk="Sedef Mavi", Fiyat=1857000 } },
            { 104, new Araba { Marka="Tesla", Model="Model S", Renk="Beyaz",  Fiyat=1750000 } }
        };
            
            char tl = '\u00A8';
            foreach (var index in Enumerable.Range(100, 4))
            {
                Console.WriteLine(index+" numaralı araba "+ cars[index].Marka+", "+cars[index].Model+", " +cars[index].Renk+" ve "+cars[index].Fiyat+ "tl₺ \u00A8" +  tl);
            }
            Console.ReadLine();


        }
    }
}
