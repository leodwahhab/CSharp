using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar objeto da classe aluno
            Aluno a = new Aluno();
            a.nome = "Denis";
            a.nota1 = 1;
            a.nota2 = 10;
            a.mensagem();
        }
    }
}
