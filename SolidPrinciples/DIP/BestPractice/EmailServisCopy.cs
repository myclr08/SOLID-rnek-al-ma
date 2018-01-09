using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP.BestPractice
{
    public class EmailServisCopy : IMessage
    {
        public void sendMessage(string message, string email)
        {
            throw new NotImplementedException();
        }
    }
}
