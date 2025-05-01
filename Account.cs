using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.Models
{
    public abstract class Account
    {
        public int AccountId { get; set; }
        public decimal Balance { get; set; }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= Balance)
                Balance -= amount;
            else
                throw new Exception("Insufficient funds.");
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}