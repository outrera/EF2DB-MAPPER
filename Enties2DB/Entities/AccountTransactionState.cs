using Match.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class AccountTransactionState
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }


}

