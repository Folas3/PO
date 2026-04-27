using System;

namespace ProdutoApp
{
    class Produto
    {
        public string CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public void ReceberDados()
        {
            Console.Write("Digite o código do produto: ");
            CodigoProduto = Console.ReadLine();

            Console.Write("Digite o nome do produto: ");
            NomeProduto = Console.ReadLine();

            Console.Write("Digite o preço: ");
            Preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade em estoque: ");
            QuantidadeEstoque = Convert.ToInt32(Console.ReadLine());
        }

        public void AdicionarEstoque()
        {
            Console.Write("Digite a quantidade para adicionar: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            QuantidadeEstoque += quantidade;
            Console.WriteLine("Estoque atualizado com sucesso!");
        }

        public void RemoverEstoque()
        {
            Console.Write("Digite a quantidade para remover: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            if (quantidade <= QuantidadeEstoque)
            {
                QuantidadeEstoque -= quantidade;
                Console.WriteLine("Remoção realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente em estoque!");
            }
        }

        public void MostrarProduto()
        {
            Console.WriteLine("\n===== DADOS DO PRODUTO =====");
            Console.WriteLine($"Código: {CodigoProduto}");
            Console.WriteLine($"Nome: {NomeProduto}");
            Console.WriteLine($"Preço: R$ {Preco:F2}");
            Console.WriteLine($"Quantidade em Estoque: {QuantidadeEstoque}");
        }
    }
}