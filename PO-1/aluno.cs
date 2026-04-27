using System;

class Aluno
{
    public string RA;
    public string Nome;
    public double NotaProva;
    public double NotaTrabalho;
    public double NotaFinal;

    public void ReceberDados()
    {
        Console.Write("RA: ");
        RA = Console.ReadLine();

        Console.Write("Nome: ");
        Nome = Console.ReadLine();

        Console.Write("Nota Prova: ");
        NotaProva = double.Parse(Console.ReadLine());

        Console.Write("Nota Trabalho: ");
        NotaTrabalho = double.Parse(Console.ReadLine());
    }

    public void CalcularMedia()
    {
        NotaFinal = (NotaProva + NotaTrabalho) / 2;
    }

    public bool CalcularNotaFinal()
    {
        if (NotaFinal >= 60)
        {
            Console.WriteLine("Aprovado direto!");
            return true;
        }
        else
        {
            double falta = 60 - NotaFinal;
            Console.WriteLine($"Precisa tirar {falta} na final.");
            return false;
        }
    }

    public void ImprimirNotaFinal()
    {
        Console.WriteLine($"Nota Final: {NotaFinal}");
    }
}