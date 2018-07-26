using System;
using System.Collections.Generic;

namespace c_sharp
{
    class Program
    {
        static void Main(string[] args) //void means you're not returning anything.
        {
            var newAccount = new BankAccount("Chris", 88);
            Console.WriteLine("Account {0} created for {1} with the initial balance of ${2}", newAccount.Number, newAccount.Owner, newAccount.Balance);
            newAccount.MakeDeposit(Convert.ToDecimal(100.44), DateTime.Now, "Got paid!");
            newAccount.MakeDeposit(Convert.ToDecimal(242.44), DateTime.Now, "Got paid!");
            newAccount.MakeWithdrawal(Convert.ToDecimal(88.55), DateTime.Now, "Paying phone bill.");
            Console.WriteLine("Bank account balance = {0}", newAccount.Balance);
            Console.WriteLine(newAccount.ViewStatements());

            // try
            // {
            //     var invalidAccount = new BankAccount("invalid", -55);
            // }
            // catch (ArgumentOutOfRangeException e)
            // {
            //     Console.WriteLine("Exception caught creatinga ccount with negative balance");
            //     Console.WriteLine(e.ToString());
            // }
            // newAccount.MakeWithdrawal(5555, DateTime.Now, "heheh");
            // Console.WriteLine("New balance of {0}", newAccount.Balance);
        }
    }
    public class BankAccount
    {
        private List<Transaction> allTransactions = new List<Transaction>();
        public string Number {get;}
        public string Owner {get; set;}
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive!");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }
       public void MakeWithdrawal(decimal amount, DateTime date, string note)
       {
           if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be greater than 0!");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds!");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
       }
       public BankAccount(string name, decimal initialBalance)
       {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
       }
       public string ViewStatements(){ // I'm going to be returning a string below, so this will be a "string functionName" method
        var report = new System.Text.StringBuilder();
            report.AppendLine("Date\t\tAmount\tNote");
            foreach (var item in allTransactions)
            {
                // Console.WriteLine("Transaction of {0} made on {1} for reason of {2}", item.Amount, item.Date, item.Notes);
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }
          return report.ToString(); // define what type of data it'll be returning in method declaration
        }

       private static int accountNumberSeed = 1000000001;
      
    }
}
