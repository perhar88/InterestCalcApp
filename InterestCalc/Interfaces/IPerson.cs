using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalc.Models
{
    public interface IPerson
    {
        List<Wallet> Wallets { get; set; }
    }
}
