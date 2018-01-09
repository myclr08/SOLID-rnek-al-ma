using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.BadPractice
{
    public enum SatısTipi
    {
        KrediKartı,
        Nakit,
        SanalKart,
        QRKod
    }
    public class SatınAlmaServis
    {
        //değişime açık gelişime kapalı
        //ocp nin tam tersi

        public void SatınAl(SatısTipi tip)
        {
            switch (tip)
            {
                case SatısTipi.KrediKartı:

                    //kredi kartı satışı

                    break;
                case SatısTipi.Nakit:
                    //nakitse 
                    break;
                case SatısTipi.SanalKart:
                    break;
                //sanal kart
                case SatısTipi.QRKod:
                    break;
                default:
                    break;
            }
        }
    }
}
