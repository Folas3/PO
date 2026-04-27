using System;

namespace HotelApp
{
    class Reserva
    {
        public string NumeroReserva { get; set; }
        public int QuantidadeDiarias { get; set; }
        public double ValorDiaria { get; set; }
        public double ValorTotal { get; set; }

        public void ReceberDadosReserva()
        {
            Console.Write("Digite o número da reserva: ");
            NumeroReserva = Console.ReadLine();

            Console.Write("Digite a quantidade de diárias: ");
            QuantidadeDiarias = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor da diária: ");
            ValorDiaria = Convert.ToDouble(Console.ReadLine());
        }

        public void CalcularTotal()
        {
            ValorTotal = QuantidadeDiarias * ValorDiaria;
        }

        public void AplicarDesconto(double percentual)
        {
            ValorTotal -= ValorTotal * (percentual / 100);
        }

        public void MostrarReserva()
        {
            Console.WriteLine("\n===== DADOS DA RESERVA =====");
            Console.WriteLine($"Número da Reserva: {NumeroReserva}");
            Console.WriteLine($"Quantidade de Diárias: {QuantidadeDiarias}");
            Console.WriteLine($"Valor da Diária: R$ {ValorDiaria:F2}");
            Console.WriteLine($"Valor Total: R$ {ValorTotal:F2}");
        }
    }
}