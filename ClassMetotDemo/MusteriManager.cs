using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi, Müşteri bilgileri:\n "  +musteri.Id+ "\n" + musteri.Ad+ "\n"+ musteri.SoyAd);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi :\n " + musteri.Id + "\n" + musteri.Ad + "\n" + musteri.SoyAd );
        }
    }
}
