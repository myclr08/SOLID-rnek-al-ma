using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP.BestPractice
{
    public class EmailFactory
    {
        public static EmailServis EmailServisInstance()
        {
            return new EmailServis();
        }
    }
}
