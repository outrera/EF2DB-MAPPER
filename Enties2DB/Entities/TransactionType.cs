using Match.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class TransactionType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
