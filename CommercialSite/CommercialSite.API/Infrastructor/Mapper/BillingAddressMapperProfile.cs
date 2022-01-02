using AutoMapper;
using CommercialSite.Common.DTOs.BillingAddress;
using CommercialSite.Common.Extensions;
using CommercialSite.Model.Entities;

namespace CommercialSite.API.Infrastructor.Mapper
{
    public class BillingAddressMapperProfile : Profile
    {
        public BillingAddressMapperProfile()
        {
            CreateMap<BillingAddress, BillingAddressRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<BillingAddress, BillingAddressResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
