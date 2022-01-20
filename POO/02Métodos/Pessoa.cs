using System;

class Pessoa
{
    //método 1
    public void apresentar ()
    {
        Console.WriteLine("Olá!!!");
    }
    //método 2
    public void apresentar (string nome)
    {
        Console.WriteLine("Olá " + nome);
    } 
    //método 3
    public void apresentar (string nome, int idade)
    {
        Console.WriteLine("Olá " + nome + ", você tem " + idade + " anos");    
    }
}