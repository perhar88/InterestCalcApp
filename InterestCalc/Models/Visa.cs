using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalc.Models
{
    public class Visa : CreditCard
    {
        public Visa(double balance)
        {
            InterestRate = 0.1;
            Balance = balance;
        }

        public Visa() { }
        
    }
}
