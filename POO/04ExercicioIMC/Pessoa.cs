using System;

class Pessoa 
{
    //atributos 
    public double peso, altura;

    //metodos
    //calculo
    public double calculo()
    {
        return peso / (altura * altura);
    }

    //situacao
    public string situacao (double imc)
    {   
        //variavel
        string retorno;

        //condcional
        if(imc < 18.5)
        {
            retorno = "abaixo do peso";
        }
        else if(imc < 25)
        {
            retorno = "peso normal";
        }
        else if(imc < 30)
        {
            retorno = "acima do peso";
        }
        else if(imc < 35)
        {
            retorno = "obesidade 1";
        }
        else if(imc < 40)
        {
            retorno = "obesidade 2";
        }
        else
        {
            retorno = "obesidade 3";
        }
        return retorno;
    }

    public void mensagem()
    {
        double obterIMC = calculo();
        string obterSituacao = situacao(obterIMC);

        Console.WriteLine("sua situacao é de " + obterSituacao + "com imc de " + obterIMC);

    }
}