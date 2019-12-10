using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public partial class Permission
    {
        public Permission()
        {
            User = new HashSet<User>();
        }

        public int PermissionId { get; set; }
        public string PermissionTitle { get; set; }
        public string PermissionDescription { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
