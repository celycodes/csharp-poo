using System;
using System.Globalization;

namespace conditionalExpressionTernaria {
    class Program {
        static void Main(string[] args) {
            Console.Write("enter the price: $");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /* expressão condicional ternária = é uma sintaxe alternativa ao if-else
            (condição) ? valor_se_verdadeiro : valor_se_falso */

            double discount = (price < 20.0) ? price * 0.1 : price * 0.05;
            
            Console.WriteLine("Discont: $" + discount.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
