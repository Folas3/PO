using System;

namespace HotelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospede hospede = new Hospede();
            Reserva reserva = new Reserva();

            hospede.ReceberDados();

            Console.Write("\nDigite o novo telefone para atualizar: ");
            string novoTelefone = Console.ReadLine();
            hospede.AtualizarTelefone(novoTelefone);

            reserva.ReceberDadosReserva();
            reserva.CalcularTotal();

            Console.Write("Digite o percentual de desconto: ");
            double desconto = Convert.ToDouble(Console.ReadLine());

            reserva.AplicarDesconto(desconto);

            hospede.MostrarDados();
            reserva.MostrarReserva();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}