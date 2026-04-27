using System;

namespace PedidosApp
{
    class Produto
    {
        private double precoUnitario;
        private int quantidade;

        public string Descricao { get; set; }

        public double PrecoUnitario
        {
            get { return precoUnitario; }
            set
            {
                if (value >= 0)
                    precoUnitario = value;
            }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set
            {
                if (value > 0)
                    quantidade = value;
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Produto: {Descricao} | Preço: R$ {PrecoUnitario:F2} | Quantidade: {Quantidade}");
        }

        public double CalcularSubtotal()
        {
            return PrecoUnitario * Quantidade;
        }
    }
}