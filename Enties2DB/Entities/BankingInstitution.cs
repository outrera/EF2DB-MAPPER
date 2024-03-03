using Match.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
//ou
namespace Match.Domain.Models
{
    public class BankingInstitution 
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public int BankingInstitutionTypeId { get; set; }

        public string Phone { get; set; }
        public string Country { get; set; }

        public bool IsActive { get; set; }
        
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        
    }
}
