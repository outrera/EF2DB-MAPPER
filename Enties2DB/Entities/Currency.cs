using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class Currency
    {
        public int? Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<User> Users { get; set; }
        public List<AgentCurrency> AgentCurrency { get; set; }
        public List<Balance> Balances { get; set; }
        public List<BalanceBonus> BalanceBonuses { get; set; }
        public List<Commission> Commissions { get; set; }
        public Currency()
        {
            IsActive = true;
        }
    }
}
