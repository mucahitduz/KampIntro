using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gerçek Müşteri Mücahit DÜZ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mücahit";
            musteri1.Soyadi = "DÜZ";
            musteri1.TcNo = "12345678912";

            //Tüzel Müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "98765";
            musteri2.SirketAdi = "Kodlama";
            musteri2.VergiNo = "123445678910";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

        }
    }
}
