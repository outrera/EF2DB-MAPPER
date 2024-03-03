using Match.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class Rol
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RolPermission> RolPermissions { get; set; }
        public List<UserBackOffice> UserBackOffices { get; set; }
    }
}
