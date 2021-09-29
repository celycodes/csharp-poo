using System;
using System.Globalization;

namespace ex03 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre com o valor do raio: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = CircumferenceCalculator.Circumference(radius);
            double volu = CircumferenceCalculator.Volume(radius);

            Console.WriteLine("Circunferência: " + circ.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volu.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + CircumferenceCalculator.Pi.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
