using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi :" + musteri.Name);
        }

        public void Update(Musteri musteri) 
        {
            Console.WriteLine("Müşteri güncellendi :"+musteri.ID+" "+musteri.Name);
        }

        public void List(Musteri musteri1,Musteri musteri2) 
        {
            Console.WriteLine("Listelendi :"+musteri1.Name+" "+ musteri2.Name);
        }
    }
}
