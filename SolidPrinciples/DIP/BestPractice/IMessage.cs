using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP.BestPractice
{
    public interface IMessage
    {
        void sendMessage(string message, string email);
    }
}
