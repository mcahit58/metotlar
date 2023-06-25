using System.Security.Claims;

namespace metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double Fiyati = 15;
            string Aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmas";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 50;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");

            }

            Console.WriteLine("--------Metotlar---------");

            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "yeşil Armut", 15, 10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 15, 5);
            sepetManager.Ekle2("Elma", "yeşil Elma", 15, 1);






        }
    }
}