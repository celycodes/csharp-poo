using System;
using System.Globalization;

namespace rectangleArea {
    class Program {
        static void Main(string[] args) {
            Rectangle x;
            x = new Rectangle();

            Console.WriteLine("Digite as medidas do Retângulo: ");
            x.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = x.Area();
            double perimeter = x.Perimeter();
            double diagonal = x.Diagonal();

            Console.WriteLine("Área de X = " + area.ToString("f2", CultureInfo.InvariantCulture) + " m²");
            Console.WriteLine("Perímetro de X = " + perimeter.ToString("f2", CultureInfo.InvariantCulture) + " m");
            Console.WriteLine("Diagonal de X = " + diagonal.ToString("f2", CultureInfo.InvariantCulture) + " m");
        }
    }
}
