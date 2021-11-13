using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 320000;
            double faizOrani = 1.45;
            double dolarDun = 7.35;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }

            else
            {
                Console.WriteLine("Eşittir Oku");
            }

            bool sistemeGirisYapmısMı = false;
            if (sistemeGirisYapmısMı==true)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
