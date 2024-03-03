using System;

namespace Match.Domain.Models;

public class AccountTransactionMovement
{
    public int? Id { get; set; }
    public int AccountTransactionId { get; set; }
    public int? AccountIdCaribe { get; set; }
    public string TransactionNumber { get; set; }
    public string TransactionAlternativeNumber { get; set; }
    public decimal TransactionAmount { get; set; }
    public decimal TransactionFragmentedAmount { get; set; }
    public string CurrencyCode { get; set; }
    
    public int? StateId { get; set; }
    public string StateName { get; set; }
    
    public int? ResponsibleId { get; set; }
    public string ResponsibleName { get; set; }
    
    public string Comment { get; set; }
    public bool? IsActive { get; set; }
    
    public DateTime? TransactionDate { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    
}
