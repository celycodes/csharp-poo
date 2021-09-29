using System;
using System.Collections.Generic;
using System.Text;

namespace simpleRegister {
    class Worker {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary() {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double value) {
            double increase = GrossSalary * (value / 100);
            GrossSalary += increase;
        }

        public override string ToString() {
            return Name + "| R$ " + NetSalary();
        }
    }
}
