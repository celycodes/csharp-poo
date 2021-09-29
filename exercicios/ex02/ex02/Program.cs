using System;
using System.Globalization;

namespace ex02 {
    class Program {
        static void Main(string[] args) {
            Employee e1, e2;
            e1 = new Employee();
            e2 = new Employee();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            e1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            e1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            e2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            e2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double averageSalary = (e1.Salary + e2.Salary) / 2.0; // salário médio
            Console.Write("Salário Médio = " + averageSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
