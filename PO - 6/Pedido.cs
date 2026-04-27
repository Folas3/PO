using System;

namespace PedidosApp
{
    class Pedido
    {
        public int Numero { get; }

        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public Produto Produto { get; set; }
        public Pagamento Pagamento { get; set; }
        public Entrega Entrega { get; set; }

        public Pedido(int numero)
        {
            Numero = numero;
        }

        public double CalcularValorFinal()
        {
            double subtotal = Produto.CalcularSubtotal();
            double entrega = Entrega.CalcularTaxaEntrega();
            double acrescimo = Pagamento.CalcularAcrescimo(subtotal);

            return subtotal + entrega + acrescimo;
        }

        public double CalcularComissaoVendedor()
        {
            return Vendedor.CalcularComissao(CalcularValorFinal());
        }

        public void ExibirResumo()
        {
            Console.WriteLine("\n===== RESUMO DO PEDIDO =====");
            Console.WriteLine($"Número: {Numero}");

            Cliente.ExibirDados();
            Vendedor.ExibirDados();
            Produto.ExibirDados();
            Pagamento.ExibirDados();
            Entrega.ExibirDados();

            Console.WriteLine($"Valor Final: R$ {CalcularValorFinal():F2}");
            Console.WriteLine($"Comissão do Vendedor: R$ {CalcularComissaoVendedor():F2}");
        }
    }
}