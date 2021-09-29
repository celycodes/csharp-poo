using System;
using System.Globalization;
using System.Collections.Generic;

namespace simpleEmployeeRegistration {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registared? ");
            int option = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();

            for (int i = 0; i < option; i++) {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i+1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                // add a new employee at list
                //list.Add(new Employee() { Id = id, Name = name, Salary = salary });
                list.Add(new Employee(id, name, salary));
            }

            Console.WriteLine();
            Console.Write("Enter the employee Id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);

            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This Id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employess:");
            foreach (Employee obj in list ) {
                Console.WriteLine();
            }
        }
    }
}
