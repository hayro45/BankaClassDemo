using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı müşteri başarıyla eklendi.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı müşteri başarıyla silindi.");
        }

        public void Listele(List<Musteri> musteriler) 
        {
            Console.WriteLine(" ");
            Console.WriteLine("Müşteriler ");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("{0}. Ad: {1} Soyad: {2} Bakiye: {3} TL",musteri.Id, musteri.Ad, musteri.Soyad, musteri.Bakiye);
            }
        }

        public void ParaYukle(Musteri musteri, int para)
        {
            musteri.Bakiye += para;
            Console.WriteLine("Başarıyla {0} adlı kişinin bakiyesine {1} TL yüklendi.", musteri.Ad, para);
        }

        public void ParaCek(Musteri musteri, int para)
        {
            musteri.Bakiye -= para;
            Console.WriteLine("Başarıyla {0} adlı kişinin bakiyesinden {1} TL çekildi.", musteri.Ad, para);

        }
    }
}
