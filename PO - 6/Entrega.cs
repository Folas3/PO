using System;

namespace PedidosApp
{
    class Entrega
    {
        private double distanciaKm;

        public string Endereco { get; set; }
        public string TipoEntrega { get; set; }

        public double DistanciaKm
        {
            get { return distanciaKm; }
            set
            {
                if (value >= 0)
                    distanciaKm = value;
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Entrega: {Endereco} | Distância: {DistanciaKm} km | Tipo: {TipoEntrega}");
        }

        public double CalcularTaxaEntrega()
        {
            return DistanciaKm * 2;
        }
    }
}