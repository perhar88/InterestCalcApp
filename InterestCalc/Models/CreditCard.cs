using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalc.Models
{
    public class CreditCard : ICreditCard
    {
        // Constructors:
        public CreditCard(double interestRate, double balance, CardEnum.CardType card)
        {
            Card = card;
            InterestRate = interestRate;
            Balance = balance;
        }

        public CreditCard() { }

        public CardEnum.CardType Card { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; }
    }
}
