using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalc.Models
{
    public interface IWallet
    {
        List<CreditCard> Cards { get; set; }
    }
}
