using System;

namespace simpleHostSystem {
    class Program {
        static void Main(string[] args) {
            Host[] vect = new Host[10];

            Console.Write("How many rooms will be rented?");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++) {
                Console.WriteLine($"Rent #{i+1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Host(name, email);
                Console.WriteLine();
            }

            Console.WriteLine("Busy Rooms: ");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine($"{i}: {vect[i]}");
                }
            }
        }
    }
}
