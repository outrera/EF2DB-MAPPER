using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class Audit
    {
        public int Id { get; set; }
        public DateTime DateRequest { get; set; }
        public DateTime DateResponse { get; set; }
        public string Querys { get; set; }
        public string Body { get; set; }
        public string Response { get; set; }
    }
}
