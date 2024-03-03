using Match.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RolPermission> RolPermission { get; set; }
        public List<UserBackOfficePermission> UserBackOfficePermission { get; set; }
    }
}
