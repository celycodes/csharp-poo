using System;
using System.Globalization;

namespace simpleDollarConverter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("-- Conversor de Dólar Simples --");
            Console.WriteLine();

            Console.Write("Digite a cotação do dólar: ");
            double dollar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar ? ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double newValue = CurrencyConverter.DollarConverter(dollar, value);
            Console.Write("O valor a ser pago em reais: R$ " + newValue.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
