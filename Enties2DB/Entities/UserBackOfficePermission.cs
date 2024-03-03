using Match.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Match.Domain.Models
{
    public class UserBackOfficePermission
    {
        public int Id { get; set; }

        public int UserBackOfficeId { get; set; }
        public UserBackOffice UserBackOffice { get; set; }
        public int PermissionId { get; set; }
        public Permission Permission { get; set; }
    }
}
