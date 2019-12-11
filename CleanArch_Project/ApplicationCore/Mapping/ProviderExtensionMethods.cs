using System.Collections.Generic;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;

namespace ApplicationCore.Mapping
{
    public static class ProviderExtensionMethods
    {
        public static ProviderDto ConvertToProviderDto(this Provider Provider)
        {
            return new ProviderDto()
            {
                ProviderId = Provider.ProviderId,
                ProviderBrand = Provider.ProviderBrand,
                ProviderAddress = Provider.ProviderAddress,
                ProviderDescription = Provider.ProviderDescription
            };
        }
        public static IEnumerable<ProviderDto> ConvertToProviderDtos(this IEnumerable<Provider> Providers)
        {
            foreach (Provider provider in Providers)
            {
                yield return provider.ConvertToProviderDto();
            }
        }
        public static Provider ConvertToProvider(this ProviderDto ProviderDto)
        {
            return new Provider()
            {
                ProviderId = ProviderDto.ProviderId,
                ProviderBrand = ProviderDto.ProviderBrand,
                ProviderAddress = ProviderDto.ProviderAddress,
                ProviderDescription = ProviderDto.ProviderDescription
            };
        }
        public static void Map(this ProviderDto ProviderDto, Provider Provider)
        {
            Provider.ProviderId = ProviderDto.ProviderId;
            Provider.ProviderBrand = ProviderDto.ProviderBrand;
            Provider.ProviderAddress = ProviderDto.ProviderAddress;
            Provider.ProviderDescription = ProviderDto.ProviderDescription;
        }
    }
}
