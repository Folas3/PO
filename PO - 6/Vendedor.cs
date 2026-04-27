using System;

namespace PedidosApp
{
    class Vendedor
    {
        private double percentualComissao;

        public string Nome { get; set; }

        public string Matricula
        {
            get { return Nome + "10"; }
        }

        public double PercentualComissao
        {
            get { return percentualComissao; }
            set
            {
                if (value >= 0)
                    percentualComissao = value;
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Vendedor: {Nome} | Matrícula: {Matricula} | Comissão: {PercentualComissao}%");
        }

        public double CalcularComissao(double valorPedido)
        {
            return valorPedido * (PercentualComissao / 100);
        }
    }
}