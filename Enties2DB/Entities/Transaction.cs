using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class Transaction
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Country { get; set; }

        public string OperatorName { get; set; }
		public Operator Operator { get; set; }
		public int OperatorId { get; set; }

		public string BankName { get; set; }
		public Bank Bank { get; set; }
		public int BankId { get; set; }

		public string AgentName { get; set; }
		public Agent Agent { get; set; }
		public int AgentId { get; set; }

		public string LocalName { get; set; }
		public Local Local { get; set; }
		public int LocalId { get; set; }


		public string UserName { get; set; }
		public User User { get; set; }
		public int? UserId { get; set; }

		public string TicketOfficeName { get; set; }
		public TicketOffice TicketOffice { get; set; }
		public int? TicketOfficeId { get; set; }

		//public string TransactionType { get; set; }
		public string TransactionTypeName { get; set; }
		public TransactionType TransactionType { get; set; }
		public int TransactionTypeId { get; set; }

		public string ProductProviderName { get; set; }
		public string ProductName { get; set; }

		//public int TicketNumberId { get; set; }
		//public TicketNumberReference TicketNumberReference { get; set; }

		public string Ticket { get; set; }
		public IntegrationsCredentials Integration { get; set; }
		public int IntegrationId { get; set; }

		public Currency Currency { get; set; }
		public string CurrencyCode { get; set; }

		public decimal BalanceBefore { get; set; }
		public decimal BalanceAfter { get; set; }
		public decimal Amount { get; set; }

		public int AmountTypeId { get; set; }
		public string AmountTypeName { get; set; }
		public AmountType AmountType { get; set; }


		public decimal BonusBeforeDeportes { get; set; }
		public decimal BonusAfterDeportes { get; set; }

		public decimal BonusBeforeHipismo { get; set; }
		public decimal BonusAfterHipismo { get; set; }

		public decimal BonusBeforeCasino { get; set; }
		public decimal BonusAfterCasino { get; set; }

		public decimal BonusBeforeLoteria { get; set; }
		public decimal BonusAfterLoteria { get; set; }

		public string Description { get; set; }

		public Transaction()
        {
			this.CreatedAt = DateTime.UtcNow;
        }
    }
}
