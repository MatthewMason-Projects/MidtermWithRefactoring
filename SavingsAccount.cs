using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.Models
{
    public class SavingsAccount : Account
    {
        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance)
                base.Withdraw(amount);
            else
                throw new Exception("Insufficient funds in savings.");
        }
    }
}