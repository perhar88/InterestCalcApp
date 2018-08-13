using InterestCalc;
using InterestCalc.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestInterestCalc
{
    public class InterestCalcTest
    {
        private InterestCalcService CreateDefaultInterestCalcService()
        {
            return new InterestCalcService();
        }
        #region CalcInterestTests

        [Theory]
        [InlineData(100)]
        public void CheckInterestOnePersonThreeCards(double balance)
        {
            // 1 person has 1 wallet and 3 cards(1 Visa, 1 MC 1 Discover) – Each Card has a balance of $100 –
            // calculate the total interest(simple interest) for this person and per card.

            var InterestCalcService = CreateDefaultInterestCalcService();            
            
            CreditCard cardVisa = InterestCalcService.InitCard(CardEnum.CardType.Visa, balance);
            CreditCard cardMC = InterestCalcService.InitCard(CardEnum.CardType.MC, balance);
            CreditCard cardDiscover = InterestCalcService.InitCard(CardEnum.CardType.Discover, balance);
            List<CreditCard> Cards = new List<CreditCard>
            {
                cardVisa,
                cardMC,
                cardDiscover
            };
            Wallet wallet = new Wallet(Cards);
            List<Wallet> Wallets = new List<Wallet>
            {
                wallet
            };
            Person person = new Person(Wallets);

            double interestVisa = InterestCalcService.CalcInterestByCard(cardVisa);
            double interestMC = InterestCalcService.CalcInterestByCard(cardMC);
            double interestDiscover = InterestCalcService.CalcInterestByCard(cardDiscover);
            double totalInterestPerson = InterestCalcService.CalcInterestByPerson(person);

            Assert.True(interestVisa == 10, $"{interestVisa} should be 10");
            Assert.True(interestMC == 5, $"{interestMC} should be 5");
            Assert.True(interestDiscover == 1, $"{interestDiscover} should be 1");
            Assert.True(totalInterestPerson == 16, $"{totalInterestPerson} should be 16");
        }

        [Theory]
        [InlineData(100)]
        public void CheckInterestOnePersonTwoWallets(double balance)
        {
            // 1 person has 2 wallets Wallet 1 has a Visa and Discover , wallet 2 a MC -each card has $100 balance -
            // calculate the total interest(simple interest) for this person and interest per wallet

            var InterestCalcService = CreateDefaultInterestCalcService();

            CreditCard cardVisa = InterestCalcService.InitCard(CardEnum.CardType.Visa, balance);
            CreditCard cardMC = InterestCalcService.InitCard(CardEnum.CardType.MC, balance);
            CreditCard cardDiscover = InterestCalcService.InitCard(CardEnum.CardType.Discover, balance);
            List<CreditCard> Cards1 = new List<CreditCard>
            {
                cardVisa,
                cardDiscover
            };
            List<CreditCard> Cards2 = new List<CreditCard>
            {
                cardMC
            };
            Wallet wallet1 = new Wallet(Cards1);
            Wallet wallet2 = new Wallet(Cards2);
            List<Wallet> Wallets = new List<Wallet>
            {
                wallet1,
                wallet2
            };
            Person person = new Person(Wallets);

            double totalInterestPerson = InterestCalcService.CalcInterestByPerson(person);
            double totalInterestWallet1 = InterestCalcService.CalcInterestByWallet(wallet1);
            double totalInterestWallet2 = InterestCalcService.CalcInterestByWallet(wallet2);
            

            Assert.True(totalInterestPerson == 16, $"{totalInterestPerson} should be 16");
            Assert.True(totalInterestWallet1 == 11, $"{totalInterestWallet1} should be 11");
            Assert.True(totalInterestWallet2 == 5, $"{totalInterestWallet2} should be 5");
        }

        [Theory]
        [InlineData(100)]
        public void CheckInterestTwoPersonsTwoWallets(double balance)
        {
            // 2 people have 1 wallet each, person 1 has 1 wallet, with 2 cards MC and visa person 2
            // has 1 wallet – 1 visa and 1 MC - each card has $100 balance - calculate the total
            //interest(simple interest) for each person and interest per wallet

            var InterestCalcService = CreateDefaultInterestCalcService();

            CreditCard cardVisa = InterestCalcService.InitCard(CardEnum.CardType.Visa, balance);
            CreditCard cardMC = InterestCalcService.InitCard(CardEnum.CardType.MC, balance);

            List<CreditCard> Cards1 = new List<CreditCard>
            {
                cardMC,
                cardVisa
            };
            List<CreditCard> Cards2 = new List<CreditCard>
            {
                cardVisa,
                cardMC
            };

            Wallet wallet1 = new Wallet(Cards1);
            Wallet wallet2 = new Wallet(Cards2);
            List<Wallet> Wallets1 = new List<Wallet>
            {
                wallet1
            };

            List<Wallet> Wallets2 = new List<Wallet>
            {
                wallet2
            };
            Person person1 = new Person(Wallets1);
            Person person2 = new Person(Wallets2);

            double totalInterestPerson1 = InterestCalcService.CalcInterestByPerson(person1);
            double totalInterestWallet1 = InterestCalcService.CalcInterestByWallet(wallet1);
            double totalInterestPerson2 = InterestCalcService.CalcInterestByPerson(person2);
            double totalInterestWallet2 = InterestCalcService.CalcInterestByWallet(wallet2);


            Assert.True(totalInterestPerson1 == 15, $"{totalInterestPerson1} should be 15");
            Assert.True(totalInterestWallet1 == 15, $"{totalInterestWallet1} should be 15");
            Assert.True(totalInterestPerson2 == 15, $"{totalInterestPerson2} should be 15");
            Assert.True(totalInterestWallet2 == 15, $"{totalInterestWallet2} should be 15");
        }
        #endregion

    }
}