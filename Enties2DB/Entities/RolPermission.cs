using Match.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class RolPermission
    {
        public int Id { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }
        public int PermissionId { get; set; }
        public Permission Permission { get; set; }
    }
}
