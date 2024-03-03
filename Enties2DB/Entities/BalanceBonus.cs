
using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class BalanceBonus
    {
        public long Id { get; set; }
        public decimal Balance { get; set; }

        public string CurrencyCode { get; set; }
        public Currency Currency { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        // Class enums/ProductGroup
        public string Group { get; set; }
    }
}
