using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Uğur";
            int yas = 24;
            int x = 10;
            int y = 20;
            var sonuc = x > y ? "x is greater than y" : "x is less than y";
            Console.WriteLine(sonuc);

            //Ternary Operatörü
            //            if else in tek satırlık kodu
            //if (x > y)
            //                Console.WriteLine("x büyük");
            //            else
            //                Console.WriteLine("y büyük"); halini
            //string cevap = x > y ? "x büyük" : "y büyük";

            //            Yazarız
            //            Çalışma Mantığı
            //string Cevap = koşuluyazarrız ? Koşul doğru ise olacak olan: Koşul yanlış ise olacak olan


            switch (x)
            {
                case 5:
                    Console.WriteLine("x= 5");
                    break;
                case 10:
                    Console.WriteLine("x= 10");
                    break;
                case 15:
                    Console.WriteLine("x= 15");
                    break;
                default:
                    Console.WriteLine("bilemedim");
                    break;
            }
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Eğitmen = "Engin";
            kurs1.IzlenmeOranı = 25;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Kamil";
            kurs2.IzlenmeOranı = 85;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "c#";
            kurs3.Eğitmen = "Demir";
            kurs3.IzlenmeOranı = 55;


            Console.WriteLine(kurs1.KursAdi+" : "+kurs1.Eğitmen);
            
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi + " : " + item.Eğitmen);
            }

            Kişi kişi1 = new Kişi();
            Kişi kişi2 = new Kişi();
            Kişi kişi3 = new Kişi();
            kişi1.dogumYılı = 1995;
            kişi1.KişiAd = "uğur" + "Demir";
            kişi1.Soyad = "demir" + "demir";
            kişi2.dogumYılı = 2002;
            kişi2.KişiAd = "burak";
            kişi2.Soyad = "arda" + "demir";
            kişi1.dogumYılı = 1995;
            kişi1.KişiAd = "uğur" + "Demir";
            kişi1.Soyad = "demir" + "demir";



            Console.WriteLine(kişi1.KişiAd + " ismindeki kişi " + kişi2.dogumYılı + " yılında doğup soy ismi : " + kişi3.Soyad + "'dır");

            Product product1 = new Product();
            product1.productName = "Bant";
            product1.productType = "Ucuz";
            product1.productPrice = 10;
            Product product2 = new Product();
            product2.productName = "Kitap";
            product2.productType = "Orta";
            product2.productPrice = 20;
            Product product3 = new Product();
            product3.productName = "Dolma Kalem";
            product3.productType = "Pahalı";
            product3.productPrice = 100;


            Product[] products = new Product[] {product1, product2,product3 };

            foreach (var product in products)
            {
                Console.WriteLine(product.productName + " isimli ürün \n" +
                                    product.productType + " titpinde\n"+
                                    product.productPrice+" fiyatındadır.");
            }

            int i = 0;
            for (i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].productName + " isimli ürün \n" +
                                    products[i].productType + " titpinde\n" +
                                    products[i].productPrice + " fiyatındadır.");
            }
            i = 0;
            while (i < products.Length)
            {
                Console.WriteLine(products[i].productName + " isimli ürün \n" +
                                     products[i].productType + " titpinde\n" +
                                     products[i].productPrice + " fiyatındadır.");
                i++;
            }


        }
    }

    class Product
    {
        public string productName { get; set; }
        public string productType { get; set; }
        public int productPrice { get; set; }

    }
    class Kişi
    {
        public string KişiAd { get; set; }
        public string Soyad { get; set; }
        public int dogumYılı { get; set; }
   
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}
}
