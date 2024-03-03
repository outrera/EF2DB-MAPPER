using Match.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class AccountTransaction 
    {
        public int Id { get; set; }
        public string TransactionNumber { get; set; }
        public int? TransactionTypeId { get; set; }
        public string TransactionTypeName { get; set; }
        public int? AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string OwnerDni { get; set; }
        public string OwnerName { get; set; }
        public int? BankInstitutionId { get; set; }
        public string BankInstitutionName { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public int? StateId { get; set; }
        public string StateName { get; set; }
        public string Comment { get; set; }
        public int? UserId { get; set; }
        public int? UserBackofficeId { get; set; }
        public string UserName { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool? IsActive { get; set; }
        public int? MeanPaymentId { get; set; }
        public string MeanPaymentName { get; set; }
    }

}
