using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler . Sepete Eklendi"+": "+urun.Adi+" "+urun.StokAdedi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler.  Sepete Eklendi : "+ urunAdi);
        }
    }
}
