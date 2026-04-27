using System;

namespace CadastroFilmesApp
{
    class Filme
    {
        public string Titulo { get; private set; }
        public string Genero { get; private set; }
        public int DuracaoMinutos { get; private set; }
        public int Classificacao { get; private set; }

        // Construtor obrigatório
        public Filme(string titulo, string genero, int duracaoMinutos, int classificacao)
        {
            Titulo = string.IsNullOrWhiteSpace(titulo) ? "Sem título" : titulo;
            Genero = string.IsNullOrWhiteSpace(genero) ? "Não informado" : genero;
            DuracaoMinutos = duracaoMinutos <= 0 ? 1 : duracaoMinutos;
            Classificacao = classificacao < 0 ? 0 : classificacao;
        }

        public void ExibirResumo()
        {
            Console.WriteLine("===== FILME =====");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Duração: {DuracaoMinutos} minutos");
            Console.WriteLine($"Classificação: {Classificacao} anos");
            Console.WriteLine();
        }

        public bool EhPermitido(int idadePessoa)
        {
            return idadePessoa >= Classificacao;
        }

        public void AlterarDuracao(int novaDuracao)
        {
            if (novaDuracao > 0)
            {
                DuracaoMinutos = novaDuracao;
            }
        }
    }
}