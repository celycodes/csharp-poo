using System;
using System.Globalization;

namespace productStock {
    class Program {
        static void Main(string[] args) {
           
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantity = int.Parse(Console.ReadLine());

            Product p = new Product(name, price, quantity);

            double Total = p.TotalValueInStock();

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quant = int.Parse(Console.ReadLine()); // valor a adicionar
            p.AddProduct(quant); // método AdicionarProdutos()

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quant = int.Parse(Console.ReadLine()); // valor a remover
            p.RemoveProduct(quant); // método RemoverProdutos()

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine(); 
        }
    }
}