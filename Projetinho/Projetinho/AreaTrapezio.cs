using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    class AreaTrapezio
    {
        public double baseMenor, baseMaior, alturaTrap;

        public double areaTrapezio()
        {
            return (baseMaior + baseMenor) * alturaTrap;
        }
    }
}
