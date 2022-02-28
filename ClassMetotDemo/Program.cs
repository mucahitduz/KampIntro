using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdiSoyadi = "Mücahit DÜZ";
            musteri1.MusteriTcNo = "12345678912";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 1;
            musteri2.MusteriAdiSoyadi = "Mücahit YAMUK";
            musteri2.MusteriTcNo = "98765432198";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
                        
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine("------------");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);

            Console.WriteLine("------------");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteriler listelendi : " + musteri.MusteriAdiSoyadi);
            }

        }
    }
}
