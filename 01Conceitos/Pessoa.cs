using System;

//classe é um "molde", algo abstrato/genérico.
class Pessoa
{
    //Atributos (características que o objeto por ter)
    public string? nome;
    public int idade;
    public string? profissao;

    //Métodos (funções)
    public void Mensagem()
    {
        Console.WriteLine("Olá, " + nome + "você tem " + idade + " anos e trabalha como " + profissao);

    }


}