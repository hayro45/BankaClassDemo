using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Hayrettin";
            musteri1.Soyad = "Dal";
            musteri1.Bakiye = 123;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Murat";
            musteri2.Soyad = "Dal";
            musteri2.Bakiye = 213;

            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            

            List<Musteri> musteriler = new List<Musteri>() { musteri1, musteri2 };
            musteriManager.Listele(musteriler);
            
            musteriManager.ParaYukle(musteri1, 54);
            musteriManager.ParaCek(musteri2,23);
          
            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri2);

            
        }
    }
}
