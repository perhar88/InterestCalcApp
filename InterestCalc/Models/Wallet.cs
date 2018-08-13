using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalc.Models
{
    public class Wallet : IWallet
    {
        // Constructors:
        public Wallet(List<CreditCard> cards)
        {
            Cards = cards;
        }

        public Wallet() { }

        public List<CreditCard> Cards { get; set; }
    }
}
