using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.BestPractice
{
    public class SatınAlmaUIManager
    {
        SatınAlmaServis _servis;

        public SatınAlmaUIManager(SatınAlmaServis servis)
        {
            _servis = servis;
        }

        public void satinAl()
        {
            _servis.SatinAl();
        }
    }
}
