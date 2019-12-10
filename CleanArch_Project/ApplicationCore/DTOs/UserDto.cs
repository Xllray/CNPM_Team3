using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class UserDto
    {
        public int UserId { get; set; }
        public int? UserPermissionId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int UserCustomerId { get; set; }

        public virtual CustomerDto UserCustomer { get; set; }
        public virtual PermissionDto UserPermission { get; set; }
    }
}
