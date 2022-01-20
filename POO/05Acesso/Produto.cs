using System;

class Produto
{
    /*
        public -> atributos e métdoso visíveis em qualquer classe
        private -> atributos e métodos visíveis apenas na classe onde são criados
        protected -> atributos e métodos visíveis em classes onde são criados ou herdados
    */
    public string nome;

    private double valor;

    public string mensagem(){
        string obterNome = nome;

        return ("ola " + obterNome + "seu preco é R$ ");
    }
}