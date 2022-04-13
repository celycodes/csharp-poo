using System;
using System.Globalization;

namespace vectorExample {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n]; // criando o vetor de tamanho n

            for (int i = 0; i < n; i++) {
                Console.Write("Digite o Nome do produto: ");
                string name = Console.ReadLine(); // variaveis auxiliares name e price
                Console.Write("Digite o Preço do produto: "); 
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product { Name = name, Price = price }; 
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i].Price;
            }

            double media = sum / n;
            Console.WriteLine("Preço médio = R$ " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
