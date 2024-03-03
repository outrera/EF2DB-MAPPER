using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class Balance
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string CurrencyCode { get; set; }
        public Currency Currency { get; set; }

        public decimal CurrentBalance { get; set; }
    }
}
