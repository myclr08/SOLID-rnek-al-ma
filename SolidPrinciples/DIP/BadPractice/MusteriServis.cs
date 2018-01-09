using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP.BadPractice
{
    //Musteri bilgilendirilmek ister
    //SMS, Email ürünler ile ilgili.
    public class MusteriServis
    {

        //Bir sınıfın içerisinde başka bir sınıfın instance direkt alamayız. bu durumda 1 tek sorumluluk ilkesine ters ve depedency inversion a ters.
        EmailServis email = new EmailServis();

        public void MusteriKayıt()
        {
            //müşteri sisteme kaydolduktan sonra email atmamız lazım
            email.MesajAt("asdasda@gmail.com", "asdasd");
        }

        public object MusteriAra(string name)
        {
            return null;
        }
    }
}
