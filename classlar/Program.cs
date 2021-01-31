using System;

namespace classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.KursAdi = "c#";
            kurs1.Eğitmen = "Engin";
            kurs1.izlenmeOrani = 68;


            kurs kurs2 = new kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Kerem";
            kurs2.izlenmeOrani = 64;


            kurs kurs3 = new kurs();
            kurs3.KursAdi = "python";
            kurs3.Eğitmen = "Berkay";
            kurs3.izlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Eğitmen);

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen);
            }


            Console.WriteLine("Hello World!");
        }
    }

    class kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
