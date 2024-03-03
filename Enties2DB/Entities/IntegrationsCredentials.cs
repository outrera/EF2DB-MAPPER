using Match.Domain.Common;

using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class IntegrationsCredentials
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public List<Transaction> Trnsactions { get; set; }
        public string Group { get; set; }
    }
}
