using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urun1Adi = "Elma";
            double fiyati1 = 15;
            string aciklama1 = "Amasya elması";

            string[] meyveler = new string[] {"Elma" , "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------");

            }

            Console.WriteLine("-------Metotlar------");

            //instance - örnek
            //encapsulation

            SepetMenager sepetMenager = new SepetMenager();
            sepetMenager.Ekle(urun1);
            sepetMenager.Ekle(urun2);

            sepetMenager.Ekle2("Armut", "Yelşk armut", 12, 10);
            sepetMenager.Ekle2("Elma", "Yelşk elma", 3, 9);
            sepetMenager.Ekle2("limon", "sarı limon", 50, 1);

        }
    }
}
