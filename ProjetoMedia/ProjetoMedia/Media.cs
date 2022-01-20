using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMedia
{
    class Media
    {
        //atributos
        public double atividade1;
        public double atividade2;
        public double atividade3;
        public double atividade4;
        public double prova1;
        public double prova2;

        //metodos
        public double calcularPesoAtividade1()
        {
            return atividade1 * 0.05;
        }
        public double calcularPesoAtividade2()
        {
            return atividade2 * 0.05;
        }
        public double calcularPesoAtividade3()
        {
            return atividade3 * 0.05;
        }
        public double calcularPesoAtividade4()
        {
            return atividade4 * 0.05;
        }
        public double calcularPesoProva1()
        {
            return prova1 * 0.3;
        }
        public double calcularPesoProva2()
        {
            return prova2 * 0.5;
        }

        public double calcularMedia ()
        {
            return (calcularPesoAtividade1() + calcularPesoAtividade2() + calcularPesoAtividade3() + calcularPesoAtividade4() + calcularPesoProva1() + calcularPesoProva2());
        }
    }
}
