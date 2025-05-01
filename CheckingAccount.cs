using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.Models
{
    public class CheckingAccount : Account
    {
        public SavingsAccount LinkedSavings { get; set; }

        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                base.Withdraw(amount);
            }
            else if (LinkedSavings != null && amount <= (Balance + LinkedSavings.Balance))
            {
                decimal deficit = amount - Balance;
                base.Withdraw(Balance);
                LinkedSavings.Withdraw(deficit);
            }
            else
            {
                throw new Exception("Insufficient funds including savings.");
            }
        }
    }
}