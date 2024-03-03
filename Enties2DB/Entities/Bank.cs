using System;
using System.Collections.Generic;
using System.Text;
using Match.Domain.Common;

namespace Match.Domain.Models
{
    public class Bank: DomainBase
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Agent> Agents { get; set; }

        public Operator Operator { get; set; }
        public int OperatorId { get; set; }

        public List<Transaction> Transactions { get; set; }

        public UserBackOffice UserBackOffice { get; set; }
        public int UserBackOfficeId { get; set; }
    }
}
