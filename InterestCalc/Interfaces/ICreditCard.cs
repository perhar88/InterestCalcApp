using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalc.Models
{
    public interface ICreditCard
    {
        double InterestRate { get; set; }
        double Balance { get; set; }
    }
}
