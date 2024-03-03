using Match.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class User: DomainBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string UserName { get; set; }

        public DateTime Birthdate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Adress { get; set; }
        public string Zip { get; set; }
        public string IPHost { get; set; }
        public string PhoneNumber { get; set; }
        public string DNI { get; set; }


        public string Email { get; set; }
        public string Password { get; set; }
        public string RefreshToken { get; set; }
        public string AccessToken { get; set; }
        //public string Provider { get; set; }
        //public string ProviderSub { get; set; }

        public string EmailVerificationToken { get; set; }
        public bool VerifiedEmail { get; set; }

        public int LocalId { get; set; }
        public Local Local { get; set; }

        public string CurrencyCode { get; set; }
        public Currency Currency { get; set; }

        public List<Transaction> Transactions { get; set; }
        public List<Balance> Balances { get; set; }
        public List<BalanceBonus> BalanceBonuses { get; set; }
    }
}
