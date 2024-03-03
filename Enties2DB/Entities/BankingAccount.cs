using Match.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class BankingAccount
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public int BankAccountTypeId { get; set; }
        public string BankingAccountTypeName { get; set; }

        public string Email { get; set; }
        public string OwnerName { get; set; }
        public string OwnerDni { get; set; }

        public int? UserId { get; set; }
        public int? UserBackofficeId { get; set; }
  
        public int? BankInstitutionId { get; set; }
        public string BankInstitutionName { get; set; }
        public string MobileNumber { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        
        
    }
}