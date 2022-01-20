using System;

class Pessoa 
{
    //Atributos -> caracteristicas q uma pessoa pode ter.
    public string nome; //public -> pode ser usado em todas as classes
    public int idade;

    //métodos -> funções
    public void mensagem () // void-> nao tem retorno
    {
        Console.WriteLine("Olá " + nome + ", você tem " + idade + " anos");
    }
}