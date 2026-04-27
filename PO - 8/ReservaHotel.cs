using System;

namespace ReservaHotelApp
{
    class ReservaHotel
    {
        public string NomeHospede { get; private set; }
        public int NumeroQuarto { get; private set; }
        public int QuantidadeDiarias { get; private set; }
        public double ValorDiaria { get; private set; }
        public string StatusReserva { get; private set; }

        public ReservaHotel(string nomeHospede, int numeroQuarto)
        {
            NomeHospede = string.IsNullOrWhiteSpace(nomeHospede) ? "Hóspede não informado" : nomeHospede;
            NumeroQuarto = numeroQuarto <= 0 ? 1 : numeroQuarto;
            QuantidadeDiarias = 1;
            ValorDiaria = 50;
            StatusReserva = "Ativa";
        }

        public ReservaHotel(string nomeHospede, int numeroQuarto, int quantidadeDiarias, double valorDiaria)
        {
            NomeHospede = string.IsNullOrWhiteSpace(nomeHospede) ? "Hóspede não informado" : nomeHospede;
            NumeroQuarto = numeroQuarto <= 0 ? 1 : numeroQuarto;
            QuantidadeDiarias = quantidadeDiarias <= 0 ? 1 : quantidadeDiarias;
            ValorDiaria = valorDiaria <= 0 ? 50 : valorDiaria;
            StatusReserva = "Ativa";
        }

        public double CalcularTotal()
        {
            return QuantidadeDiarias * ValorDiaria;
        }

        public void ExibirReserva()
        {
            Console.WriteLine("===== RESERVA =====");
            Console.WriteLine($"Hóspede: {NomeHospede}");
            Console.WriteLine($"Quarto: {NumeroQuarto}");
            Console.WriteLine($"Diárias: {QuantidadeDiarias}");
            Console.WriteLine($"Valor da diária: R$ {ValorDiaria:F2}");
            Console.WriteLine($"Status: {StatusReserva}");
            Console.WriteLine($"Total: R$ {CalcularTotal():F2}");
            Console.WriteLine();
        }

        public void AdicionarDiarias(int quantidade)
        {
            if (quantidade > 0)
            {
                QuantidadeDiarias += quantidade;
            }
        }

        public void CancelarReserva()
        {
            StatusReserva = "Cancelada";
        }

        public void ReativarReserva()
        {
            StatusReserva = "Ativa";
        }
    }
}