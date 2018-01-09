using SolidPrinciples.ISP.BadPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.BadPractice
{
    public class SimetricCryptoServis : ICryptoProvider
    {
        public string Decrypte(string chipperText)
        {
            throw new NotImplementedException();
        }

        public string Encrypte(string plainText)
        {
            throw new NotImplementedException();
        }
    }
}
