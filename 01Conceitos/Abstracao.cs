
namespace Abstracao
{
    class Pagamento
    {
        DateTime Vencimento;
        void Pagar(){
            consultarSaldoDaConta();{}
        }
        private void consultarSaldoDaConta(){}
    }
}

// O private faz com que o método consultarSaldoDaConta(){} seja acessado só por quem faz sentido, no caso class Pagamento.