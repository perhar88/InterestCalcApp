using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalc.Models
{
    public class MC : CreditCard
    {
        public MC(double balance)
        {
            InterestRate = 0.05;
            Balance = balance;
        }

        public MC() { }
        
    }
}
