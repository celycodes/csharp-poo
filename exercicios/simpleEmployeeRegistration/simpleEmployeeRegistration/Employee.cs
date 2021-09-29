using System;
using System.Globalization;

namespace simpleEmployeeRegistration {
    class Employee {
        // atributos
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee( int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage) { // metodo salary increase
            double discount = Salary * (percentage / 100); // desconto
            Salary += discount;
        }

        public override string ToString() {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
