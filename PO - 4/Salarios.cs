using System;

namespace SalarioApp
{
    class Salarios
    {
        public string NomeFuncionario { get; set; }
        public double SalarioBase { get; set; }
        public double SalarioFinal { get; set; }

        public void ReceberDados()
        {
            Console.Write("Digite o nome do funcionário: ");
            NomeFuncionario = Console.ReadLine();

            Console.Write("Digite o salário base: ");
            SalarioBase = Convert.ToDouble(Console.ReadLine());

            SalarioFinal = SalarioBase;
        }

        public void CalcularAumento(double percentual)
        {
            SalarioFinal += SalarioBase * (percentual / 100);
        }

        public void CalcularDesconto(double percentual)
        {
            SalarioFinal -= SalarioBase * (percentual / 100);
        }

        public void MostrarSalario()
        {
            Console.WriteLine("\n===== DADOS DO FUNCIONÁRIO =====");
            Console.WriteLine($"Nome: {NomeFuncionario}");
            Console.WriteLine($"Salário Base: R$ {SalarioBase:F2}");
            Console.WriteLine($"Salário Final: R$ {SalarioFinal:F2}");
        }
    }
}