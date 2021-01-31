using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar2[0] ? 999
            // why
            Console.WriteLine(sayilar2[0]);

            // int, decimal, float, double , bool = değer tip
            // array, class, interface = referans tip
            // int[] sayilar1 dediğimde stack da alan oluştururken, "new" ifadesini kullandığımızda heap alanıında bir alan açar
            // array larda bir array başka array e eşitlenirse, ilk eğer in içeriği artık tutulmaz. 
        
}
    }
}
