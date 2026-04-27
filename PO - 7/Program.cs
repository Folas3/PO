using System;

namespace CadastroFilmesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Filme f1 = new Filme("Interestelar", "Ficção Científica", 169, 12);

            Filme f2 = new Filme("", "", -30, -5);

            f1.ExibirResumo();
            f2.ExibirResumo();

            Console.WriteLine("Pessoa com 10 anos pode assistir? " + f1.EhPermitido(10));
            Console.WriteLine("Pessoa com 15 anos pode assistir? " + f1.EhPermitido(15));

            Console.WriteLine();

            f2.AlterarDuracao(120);
            f2.ExibirResumo();

            f2.AlterarDuracao(-50);
            f2.ExibirResumo();

            Console.ReadKey();
        }
    }
}