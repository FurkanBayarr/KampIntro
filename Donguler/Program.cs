using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(i);

            {
                //aray - dizi
                string[] kurslar = new string[] {"kurs1","kurs2","kurs3","kurs4","kurs5" };


                for (int i = 0; i <kurslar.Length ; i++) 
                
                    Console.WriteLine(kurslar[i]);

                Console.WriteLine("For Bitti");


                foreach (string kurs in kurslar)
                {
                    Console.WriteLine(kurs);

                }

                


               
               
            }
            Console.WriteLine("Sayfa Sonu - Footer");
           
        }
       
    }
}
