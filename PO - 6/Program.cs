using System;

namespace PedidosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente { Nome = "João", Cpf = "123456789", Cidade = "Araxá" };

            Vendedor v = new Vendedor { Nome = "Carlos", PercentualComissao = 10 };

            Produto p = new Produto { Descricao = "Notebook", PrecoUnitario = 3000, Quantidade = 2 };

            Pagamento pg = new Pagamento { FormaPagamento = "Cartão", Parcelas = 3 };

            Entrega e = new Entrega { Endereco = "Rua A, 100", DistanciaKm = 15, TipoEntrega = "Expressa" };

            Pedido pedido = new Pedido(1)
            {
                Cliente = c,
                Vendedor = v,
                Produto = p,
                Pagamento = pg,
                Entrega = e
            };

            pedido.ExibirResumo();

            Console.ReadKey();
        }
    }
}