using System;

namespace HotelApp
{
    class Hospede
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        public void ReceberDados()
        {
            Console.Write("Digite o nome do hóspede: ");
            Nome = Console.ReadLine();

            Console.Write("Digite o CPF: ");
            Cpf = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            Telefone = Console.ReadLine();
        }

        public void MostrarDados()
        {
            Console.WriteLine("\n===== DADOS DO HÓSPEDE =====");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Telefone: {Telefone}");
        }

        public void AtualizarTelefone(string novoTelefone)
        {
            Telefone = novoTelefone;
        }
    }
}