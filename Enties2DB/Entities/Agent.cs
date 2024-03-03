using Match.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class Agent : DomainBase
    {
        public string Name { get; set; }

        public int BankId { get; set; }
        public Bank Bank { get; set; }
        public List<Local> Locals { get; set; }
        public List<AgentCurrency> AgentCurrency { get; set; }
        public List<Commission> Commissions { get; set; }

        public UserBackOffice UserBackOffice { get; set; }
        public int UserBackOfficeId { get; set; }
    }
}
