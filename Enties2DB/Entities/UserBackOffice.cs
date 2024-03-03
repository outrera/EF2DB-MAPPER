using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class UserBackOffice
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RefreshToken { get; set; }

        public List<UserBackOfficePermission> UserBackOfficePermission { get; set; }

        public int RolId { get; set; }
        public Rol Rol { get; set; }

        public Operator Operator { get; set; }
        public Bank Bank { get; set; }
        public Agent Agent { get; set; }
        public Local Local { get; set; }
    }
}
