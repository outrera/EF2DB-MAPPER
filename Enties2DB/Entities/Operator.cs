using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class Operator
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }

        public List<Bank> Banks { get; set; }
        public List<Transaction> Transactions { get; set; }

        public UserBackOffice UserBackOffice { get; set; }
        public int UserBackOfficeId { get; set; }
    }
}
