using System;

class Aluno
{
    public string nome;
    public double nota1, nota2;

    //média
    public double media()
    {
        return (nota1 + nota2) / 2;
    }

    //situação
    public string situacao (double media)
    {
        return media>=7?"aprovado":"reprovado";
    }
    //mensagem
    public void mensagem ()
    {
        //obter a media
        double obterMedia = media ();

        //obter a situacao
        string obterSituacao = situacao(obterMedia);

        //mensagem
        Console.WriteLine(nome + " está " + obterSituacao + ", com média " + obterMedia); 
    }
}
