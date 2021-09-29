using System.Globalization;

namespace simpleBankAccount {
    class BankAccount {
        // atributos
        public double DepositAmount { get; private set; } // saldo da conta
        public int AccountNumber { get; private set; }  // número da conta
        public string AccountHolder { get; set; }      // titular da conta

        public BankAccount(int accountNumber, string accountHolder) {  // construtor
            AccountNumber = accountNumber;
            AccountHolder = accountHolder; 
        }

        public BankAccount(int accountNumber, string accountHolder, double initialDeposit) : this(accountNumber, accountHolder) {
            Deposit(initialDeposit);
        }

        public void Deposit(double quantity) {
            DepositAmount += quantity;
        }

        public void Withdraw(double quantity) {
            DepositAmount -= quantity;
            DepositAmount -= 5.0; // taxa
        }

        public override string ToString() {
            return "Conta " + AccountNumber + ", Titular: " + AccountHolder + ", Saldo: R$ " + DepositAmount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
