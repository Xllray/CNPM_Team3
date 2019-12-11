using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities
{
    public partial class User : IAggregateRoot
    {
        public int UserId { get; set; }
        public int? UserPermissionId { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
        public int UserCustomerId { get; set; }

        public virtual Customer UserCustomer { get; set; }
        public virtual Permission UserPermission { get; set; }
    }
}
