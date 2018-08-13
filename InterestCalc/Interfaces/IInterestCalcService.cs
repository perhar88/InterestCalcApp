using InterestCalc.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalc.Interfaces
{
    public interface IInterestCalcService
    {
        double CalcInterestByPerson(Person person);
        double CalcInterestByWallet(Wallet wallet);
        double CalcInterestByCard(CreditCard card);
    }
}
