using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.BadPractice
{
    public interface ICryptoProvider
    {
        string Encrypte(string plainText);
        string Decrypte(string chipperText);
    }
}
