using System;

namespace paramsExample {
    class Program {
        static void Main(string[] args) {
            // modificador de parâmetros - params

            int s1 = Calculator.Sum( 2, 3);
            int s2 = Calculator.Sum(2, 3, 4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
