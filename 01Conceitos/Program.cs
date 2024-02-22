using System; //importação de funcionalidade. System é uma lib padrão.

namespace _01Conceitos //nome da pastinha
{
    class Program
    {
        static void Main(string[] args) // static void Main é um arquivo único que roda todo o projeto.
        {
            // Instanciar um objeto, quer dizer: criando um objeto a partir de um molde
            //Aqui estou instanciando um objeto com base na class Pessoa.
            Pessoa obj = new()
            {
                nome = "Flávio",
                idade = 31,
                profissao = "desenvolvedor"
            };
            obj.Mensagem();

        }
    }
}