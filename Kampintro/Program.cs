﻿using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself - kendini tekrarlama
            // değer tutucu , alias
           string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullancı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine("Kategori");
        }
    }
}
