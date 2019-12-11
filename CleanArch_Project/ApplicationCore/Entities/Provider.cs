using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public partial class Provider : IAggregateRoot
    {
        public Provider()
        {
            Product = new HashSet<Product>();
        }

        public int ProviderId { get; set; }
        public string ProviderBrand { get; set; }
        public string ProviderAddress { get; set; }
        public string ProviderDescription { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
