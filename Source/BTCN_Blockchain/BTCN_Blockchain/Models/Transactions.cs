using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTCN_Blockchain.Models
{
    public class Transactions
    {
        public string From { get; }
        public string To { get; }
        public double Amount { get; }
        public Transactions(string from, string to, double amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}