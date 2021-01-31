using System;

namespace homevork
{
    class Program
    {
        static void Main(string[] args)
        {
            digibabyshop bez1 = new digibabyshop();
            bez1.UrunAdi = "Sleepy";
            bez1.Aciklama = "Natural Bebek Bezi 4+ Numara Maxi Plus 130 Adet";
            bez1.DegerlendirmeOrani = 2707;
            bez1.Fiyat = 99.99;
            bez1.IndirimOrani = 10;

            digibabyshop bez2 = new digibabyshop();
            bez2.UrunAdi = "Molfix";
            bez2.Aciklama = "Bebek Bezi 4 Beden Maxi Aylık Fırsat Paketi 152";
            bez2.DegerlendirmeOrani = 1103;
            bez2.IndirimOrani = 20;
            bez2.Fiyat = 125.49;


            digibabyshop bez3 = new digibabyshop();
            bez3.UrunAdi = "EvyBaby";
            bez3.Aciklama = "Bebek bezi 4+ Beden Maxiplus 4'lü Fırsat 104 Adet";
            bez3.DegerlendirmeOrani = 37;
            bez3.Fiyat = 89.95;
            bez3.IndirimOrani = 15;

            digibabyshop[] Bezler = new digibabyshop[] {bez1,bez2,bez3};
            for (int i = 0; i < Bezler.Length; i++)
            {
                Console.WriteLine(Bezler[i].UrunAdi);
                Console.WriteLine(Bezler[i].Aciklama);
                Console.WriteLine(Bezler[i].DegerlendirmeOrani);
                Console.WriteLine(Bezler[i].IndirimOrani);
                Console.WriteLine(Bezler[i].Fiyat);
            }
            Console.WriteLine("For döngüsü bitti!");
            int j = 0;
             while (true) 
            {
                if (j == Bezler.Length)
                {
                    break;
                }
               else
                {
                    Console.WriteLine(Bezler[j].UrunAdi);
                    Console.WriteLine(Bezler[j].Aciklama);
                    Console.WriteLine(Bezler[j].DegerlendirmeOrani);
                    Console.WriteLine(Bezler[j].IndirimOrani);
                    Console.WriteLine(Bezler[j].Fiyat);
                    j++;
                }
                
            }
            Console.WriteLine("while döngüsü bitti!");
            foreach (var bez in Bezler)
            {
                Console.WriteLine(bez.UrunAdi);
                Console.WriteLine(bez.Aciklama);
                Console.WriteLine(bez.DegerlendirmeOrani);
                Console.WriteLine(bez.IndirimOrani);
                Console.WriteLine(bez.Fiyat);
            }
        }
    }
    class digibabyshop
    {
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public int DegerlendirmeOrani { get; set; }
        public double Fiyat { get; set; }
        public int IndirimOrani { get; set; }
    }
}
