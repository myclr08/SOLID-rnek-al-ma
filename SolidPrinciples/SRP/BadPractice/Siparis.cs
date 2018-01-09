using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.BadPractice
{
    public class Siparis
    {
        //sınıf sepet,siparis ve musteri işlemleri için değişebilir
        //bir sınıfın değişmesi için sadece 1 sebebinin olması gerekti.
        public void SiparisKaydet(object musteriBilgileri)
        {

        }
        
        public void SepeteEkle(List<string> items)
        {

        }

        public object MusteriBilgileriniGetir()
        {
            return null;
        }
    }
}
