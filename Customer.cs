using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int Pin { get; set; }
        public CheckingAccount Checking { get; set; }
        public SavingsAccount Savings { get; set; }
    }
}
