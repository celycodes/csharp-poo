using System;
using System.Globalization;

namespace simpleRegister {
    class Program {
        static void Main(string[] args) {
            Worker p;
            p = new Worker();

            Console.WriteLine("Digite os dados do trabalhador(a):");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            p.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            p.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Trabalhador(a): " + p);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // valor a adicionar
            p.IncreaseSalary(value); // método aumentar salário

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
        }
    }
}
