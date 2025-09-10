using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    internal class Account
    {
        private decimal _balance;

        public Account()
        {
            _balance = 0.0M;
        }
        public Account(decimal balance)
        {
            if (balance < 0) throw new ArgumentException("Intial Balance cannot be Negative!");
            _balance = balance;
        }
        // getter setter methods
        public decimal GetBalance() { return _balance; }
        public void SetBalance(decimal balance) {
            if (balance < 0) throw new ArgumentException("Intial Balance cannot be Negative!");
            _balance = balance;
        }
        //Method - deposit
        public void Deposit(decimal amount)
        {
            if (amount < 0) throw new ArgumentException("Intial amount cannot be Negative!");
            _balance += amount;

        }
        public void Withdraw(decimal amount)
        {
            if (amount < 0 || amount> _balance) throw new ArgumentException("Insufficient funds!");
            _balance -= amount;

        }



    }
}
