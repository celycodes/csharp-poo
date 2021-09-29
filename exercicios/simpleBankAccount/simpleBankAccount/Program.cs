using System;
using System.Globalization;

namespace simpleBankAccount {
    class Program {
        static void Main(string[] args) {
            BankAccount account;

            Console.WriteLine("Entre com os dados do Conta Bancária: ");
            Console.Write("Número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Haverá Deposíto inicial (S/N)? ");
            string op = Console.ReadLine().ToUpper(); // opção do usuário 
            if (op == "S") {
                Console.Write("Digite o valor do déposito inicial: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new BankAccount(num,name, initialDeposit);
            }
            else {
                account = new BankAccount(num, name);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Digite o valor do depósito: ");
            double quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // deposito
            account.Deposit(quant); // método Deposito()

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Digite valor do saque: ");
            quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // saque
            account.Withdraw(quant); // método Sacar()

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);
            Console.WriteLine();
        }
    }
}
