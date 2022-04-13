using System;
using System.Globalization;

namespace triangleArea {
    class Program {
        static void Main(string[] args) {
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Digite as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área de X = " + x);
            Console.WriteLine("Área de Y = " + y);

            if (areaX > areaY) {
                Console.WriteLine("Maior Área =  X");
            }
            else {
                Console.WriteLine("Maior Área =  Y");
            }
            // calcula e compara a área de dois triângulos X e Y (update: criação da classe Triangle) 
        }
    }
}
