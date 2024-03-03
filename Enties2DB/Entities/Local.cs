using Match.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class Local : DomainBase
    {
        public string Name { get; set; }

        public int AgentId { get; set; }
        public Agent Agent { get; set; }

        public List<User> Users { get; set; }
        public List<TicketOffice> TicketOffices { get; set; }
        public List<Transaction> Transactions { get; set; }


        public UserBackOffice UserBackOffice { get; set; }
        public int UserBackOfficeId { get; set; }
    }
}
