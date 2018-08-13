using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalc.Models
{
    public class CreditCard : ICreditCard
    {
        // Constructors:
        public CreditCard(double interestRate, double balance)
        {
            InterestRate = interestRate;
            Balance = balance;
        }

        public CreditCard() { }
        
        public double InterestRate { get; set; }
        public double Balance { get; set; }
    }
}
