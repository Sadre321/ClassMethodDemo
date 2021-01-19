using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //müşteri ekleme
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.Name = "Haydar";
            musteri1.LastName = "Misirli";
            musteri1.Job = "Öğrenci";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.Name = "Mustafa";
            musteri2.LastName = "Başpınar";
            musteri2.Job = "Öğrenci";

           
            //müşteri yönetimi
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.List(musteri1, musteri2);
            musteriManager.Delete(musteri1);
            musteriManager.Update(musteri2);
        }
    }
}
