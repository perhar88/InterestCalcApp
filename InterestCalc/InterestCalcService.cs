using InterestCalc.Interfaces;
using InterestCalc.Models;
using System;

namespace InterestCalc
{
    public class InterestCalcService : IInterestCalcService
    {
        public double CalcInterestByPerson(Person person)
        {
            double PersonTotalInterest = 0;
            foreach (Wallet wallet in person.Wallets)
            {
                PersonTotalInterest = PersonTotalInterest + CalcInterestByWallet(wallet);
            }

            return PersonTotalInterest;
        }

        public double CalcInterestByWallet(Wallet wallet)
        {
            double WalletTotalInterest = 0;
                foreach (CreditCard creditCard in wallet.Cards)
                {
                WalletTotalInterest = WalletTotalInterest + CalcInterestByCard(creditCard);
                }

            return WalletTotalInterest;
        }

        public double CalcInterestByCard(CreditCard card)
        {
            double CardInterest;
            CardInterest = card.InterestRate * card.Balance;

            return CardInterest;
        }

        public CreditCard InitCard(CardEnum.CardType cardType, double balance)
        {
            CreditCard Card;
            switch (cardType)
            {
                case CardEnum.CardType.Visa:
                    {
                        Card = new CreditCard(0.1, balance, CardEnum.CardType.Visa);
                        return Card;
                    }
                case CardEnum.CardType.MC:
                    {
                        Card = new CreditCard(0.05, balance, CardEnum.CardType.MC);
                        return Card;
                    }
                case CardEnum.CardType.Discover:
                    {
                        Card = new CreditCard(0.01, balance, CardEnum.CardType.Discover);
                        return Card;
                    }
                default:
                    {
                        Card = null;
                        return Card;
                    }
            }

        }
    }
}
