using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.BestPractice
{
    public interface IEncryptor
    {
        string Encrypte(string plainText);
    }
}
