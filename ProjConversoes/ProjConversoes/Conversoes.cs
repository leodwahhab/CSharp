using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjConversoes
{
    class Conversoes
    {
        public double valorReal;
        public double taxa;

        public double ConversaoA()
        {
            return valorReal / taxa;
        }
        public double ConversaoB()
        {
            return valorReal * taxa;
        }
    }
}
