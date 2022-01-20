using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConversao
{
    class Conversoes
    {
        public double valorReal;
        public double taxa;

        public double Conversao()
        {
            return valorReal / taxa;
        }
    }
}
