using System;

class Pessoa
{
    //atributo 
    private string nome = "odranoel";

    //construtor
    public Pessoa (string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}