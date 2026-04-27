using System;

namespace SalarioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Salarios funcionario = new Salarios();

            funcionario.ReceberDados();

            Console.Write("Digite o percentual de aumento: ");
            double aumento = Convert.ToDouble(Console.ReadLine());

            funcionario.CalcularAumento(aumento);

            Console.Write("Digite o percentual de desconto: ");
            double desconto = Convert.ToDouble(Console.ReadLine());

            funcionario.CalcularDesconto(desconto);

            funcionario.MostrarSalario();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}