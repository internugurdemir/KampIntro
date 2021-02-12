using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string Kurs1 = "Yazılım Geliştirme Kampı";
            string Kurs2 = "Programlama Başlangıç";
            string Kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı",
                                                "Programlama Başlangıç",
                                                "Java"};

            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


        }
    }
}
