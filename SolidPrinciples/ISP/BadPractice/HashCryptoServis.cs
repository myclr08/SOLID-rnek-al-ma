using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.BadPractice
{
    public class HashCryptoServis : ICryptoProvider
    {
        public string Decrypte(string chipperText)
        {
            return null;
        }

        public string Encrypte(string plainText)
        {
            return "dsfsdY9ı78451";
        }
    }
}
