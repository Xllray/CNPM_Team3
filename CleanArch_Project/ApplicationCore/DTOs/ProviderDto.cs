using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class ProviderDto
    {
        public ProviderDto()
        {
            Product = new HashSet<ProductDto>();
        }

        public int ProviderId { get; set; }
        public string ProviderBrand { get; set; }
        public string ProviderAddress { get; set; }
        public string ProviderDescription { get; set; }

        public virtual ICollection<ProductDto> Product { get; set; }
    }
}
