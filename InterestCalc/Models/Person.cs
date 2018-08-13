using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalc.Models
{
    public class Person : IPerson
    {
        // Constructors:
        public Person(List<Wallet> wallets)
        {
            Wallets = wallets;
        }

        public Person() { }

        public List<Wallet> Wallets { get; set; }
    }
}
