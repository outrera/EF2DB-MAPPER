using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Common
{
    public class DomainBase 
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
