using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class PermissionDto
    {
        public PermissionDto()
        {
            User = new HashSet<UserDto>();
        }

        public int PermissionId { get; set; }
        public string PermissionTitle { get; set; }
        public string PermissionDescription { get; set; }

        public virtual ICollection<UserDto> User { get; set; }
    }
}
