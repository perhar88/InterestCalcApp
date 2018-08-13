using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalc.Models
{
    public interface ICreditCard
    {
        CardEnum.CardType Card { get; set; }
        double InterestRate { get; set; }
        double Balance { get; set; }
    }
}
