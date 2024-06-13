using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment.BusinessLayer
{
    public class BankAccount
    {
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            private set
            {
                balance = value;
                OnBalanceChanged();
            }
        }

        public event EventHandler BalanceChanged;

        protected virtual void OnBalanceChanged()
        {
            BalanceChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive");
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive");
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds");
            Balance -= amount;
        }

        public BankAccount(decimal initialBalance = 0)
        {
            Balance = initialBalance;
        }
    }
}