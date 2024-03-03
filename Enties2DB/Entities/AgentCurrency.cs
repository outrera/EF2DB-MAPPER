using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class AgentCurrency
    {
        public int Id { get; set; }
        public string CurrencyCode { get; set; }
        public Currency Currency { get; set; }
        public int AgentId { get; set; }
        public Agent Agent { get; set; }

    }
}
