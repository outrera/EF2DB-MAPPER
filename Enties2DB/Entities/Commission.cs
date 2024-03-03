using Match.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class Commission : DomainBase
    {
        public String CurrencyCode { get; set; }
        public Currency Currency { get; set; }

        public int AgentId { get; set; }
        public Agent Agent { get; set; }

        public int Sales { get; set; }
        public int Utility { get; set; }
        public int Share { get; set; }
        public int Share2 { get; set; }
        public int VirtualesCaribeSales { get; set; }
        public int VirtualesCaribeUtility { get; set; }
        public int PragmaticSales { get; set; }
        public int PragmaticUtility { get; set; }
    }
}
