using System;

namespace matrizExample {
    class Program {
        static void Main(string[] args) {
            Console.Write("What’s the order of matriz(arrey)? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                // i -> rows
                Console.WriteLine($"Enter the values the row #{i}:");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {
                    // j -> columns
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Main Diagonal:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------");

            int count = 0;
            for ( int i = 0; i < n; i ++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i,j] < 0) {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Amount of negative numbers: {count}");
        }
    }
}
