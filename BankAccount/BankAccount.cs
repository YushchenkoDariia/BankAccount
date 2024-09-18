using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public double Balance { get; private set; }

        private List<string> actionHistory;

        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            actionHistory = new List<string>();
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                AddToHistory($"Topped up by {amount} UAH. Current balance: {Balance} UAH.");
            }
            else
            {
                throw new ArgumentException("The top-up amount must be greater than zero.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                AddToHistory($"Withdraw {amount} UAH. Current balance: {Balance} UAH.");
            }
            else
            {
                throw new InvalidOperationException("Not enough funds in the account or the amount is incorrect.");
            }
        }

    
        private void AddToHistory(string action)
        {
            string timestamp = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            actionHistory.Insert(0, $"{timestamp} - {action}");

            if (actionHistory.Count > 10)
            {
                actionHistory.RemoveAt(10);
            }
        }

        public List<string> GetActionHistory()
        {
            return new List<string>(actionHistory);
        }
        public string GetAccountInfo()
        {
            return $"Account number: {AccountNumber}, Balance: {Balance} UAH.";
        }
    }
}

