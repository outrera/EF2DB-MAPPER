using Match.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class TicketOffice : DomainBase
    {
        public string Name { get; set; }

        public int LocalId { get; set; }
        public Local Local { get; set; }

        public string CurrencyCode { get; set; }
        public Currency Currency { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
