using System;

namespace ContaBancariaApp
{
    class ContaBancaria
    {
        public string NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; set; }

        public void ReceberDados()
        {
            Console.Write("Digite o número da conta: ");
            NumeroConta = Console.ReadLine();

            Console.Write("Digite o nome do titular: ");
            NomeTitular = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            Saldo = Convert.ToDouble(Console.ReadLine());
        }

        public void Depositar()
        {
            Console.Write("Digite o valor do depósito: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            Saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso!");
        }

        public void Sacar()
        {
            Console.Write("Digite o valor do saque: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine("\n===== DADOS DA CONTA =====");
            Console.WriteLine($"Número da Conta: {NumeroConta}");
            Console.WriteLine($"Titular: {NomeTitular}");
            Console.WriteLine($"Saldo Atual: R$ {Saldo:F2}");
        }
    }
}