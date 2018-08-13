using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalc.Models
{
    public class Discover : CreditCard
    {
        public Discover(double balance)
        {
            InterestRate = 0.01;
            Balance = balance;
        }

        public Discover() { }
    }
}

