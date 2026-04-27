using System;

namespace ContaBancariaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();

            conta.ReceberDados();
            conta.Depositar();
            conta.Sacar();
            conta.MostrarSaldo();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}