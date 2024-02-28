using System;

namespace Heranca
{
    public class Pagamento
    {
        //propriedades
        DateTime Vencimento;
        //métodos
        public void Pagar(){}
    }

    public class PagamentoBoleto : Pagamento
    {
        //aqui podemos pegar todas as propriedades, métodos e eventos da classe pai
        //aqui podemos adicionar novas propriedades, métodos e eventos.
        //ao criar uma instância do PagamentoBoleto, ele vai trazer as heranças
    }
}