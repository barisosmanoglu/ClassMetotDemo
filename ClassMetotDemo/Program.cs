using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1234567891;
            musteri1.Ad = "Barış";
            musteri1.SoyAd = "Osmanoğlu";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1234567892;
            musteri2.Ad = "Baha";
            musteri2.SoyAd = "Osmanoğlu";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1234567893;
            musteri3.Ad = "Mustafa";
            musteri3.SoyAd = "Osmanoğlu";

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.MusteriEkleme(musteri1);
            musterimanager.MusteriEkleme(musteri2);
            musterimanager.MusteriEkleme(musteri3);
            
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Kayıtlı Müşterilerin Listesi ;");
           
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.SoyAd);
                
            }

            Console.WriteLine("---------------------------------------------------------------");

            musterimanager.MusteriSil(musteri1);
            musterimanager.MusteriSil(musteri2);
            musterimanager.MusteriSil(musteri3);

            Console.ReadLine();


        }
    }
}
