using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOYUTLAMA



            //Gerçek Müşteri
            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.Adi = "Uğur";
            musteri1.Soyadi = "Demir";
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";


            //Tüzel Müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "512345";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "00017654564";

            //""                        ╔>REF.NO
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            //SOLID
            //L HARFİ inheritance ı farklı al


            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri = new Musteri();
            musteri.MusteriId = 15;
            musteri.MusteriAd = "Çağrı";
            musteri.MusteriSoyad = "Kibar";

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 16;
            musteri1.MusteriAd = "Umutcan";
            musteri1.MusteriSoyad = "Kibar";

            Musteri[] musteris = new Musteri[] { musteri, musteri1 };
            foreach (var musteriler in musteris)
            {
                Console.WriteLine("Müşteri Id: " + musteri.MusteriId + ":  Müşteri Adı:  " + musteri.MusteriAd + ":  Müşteri Soyadı: " + musteri.MusteriSoyad);
            }

            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri);
            musteriManager.Update(musteri);
        }
    }
}
