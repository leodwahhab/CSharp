using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDolarReal
{
    class Conversao
    {
        public double valor;

        public double DolarReal()
        {
            return valor * 5.07;
        }
        public double RealDolar()
        {
            return valor / 5.07;
        }
    }
}
