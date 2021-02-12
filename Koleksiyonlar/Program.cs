using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{



    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Halil","Demir","Kerem" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];      //Yeni array oluşur
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            List<string> isimler2 = new List<string> { "Engin", "Halil", "Demir", "Kerem" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2);
            for (int i = 0; i < isimler2.Count; i++) { Console.WriteLine(isimler2[i]); }


            isimler2.Add("İlker" + " Kadim=Son nesne==============");//Tek değer ekler -SonaEkle
            for (int i = 0; i < isimler2.Count; i++) { Console.WriteLine(isimler2[i]); }

            isimler2.Insert(0, "Hakim");//0.indexe ekler
            for (int i = 0; i < isimler2.Count; i++) { Console.WriteLine(isimler2[i]); }
            isimler2.Sort();
            for (int i = 0; i < isimler2.Count; i++) { Console.WriteLine(isimler2[i]); }
            isimler2.Add("--------------------------------------------------------------------------");//EN SON-SonaEkle
            for (int i = 0; i < isimler2.Count; i++) { Console.WriteLine(isimler2[i]); }


            isimler2.Reverse();

            for (int i = 0; i < isimler2.Count; i++) { Console.WriteLine(isimler2[i]); }

            Console.ReadLine();
        }
    }
}
