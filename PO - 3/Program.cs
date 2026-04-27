using System;

namespace ProdutoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            produto.ReceberDados();
            produto.AdicionarEstoque();
            produto.RemoverEstoque();
            produto.MostrarProduto();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}