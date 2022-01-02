using AutoMapper;
using CommercialSite.Common.DTOs.ShipmentInfo;
using CommercialSite.Common.DTOs.ShippingAddress;
using CommercialSite.Common.Extensions;
using CommercialSite.Model.Entities;

namespace CommercialSite.API.Infrastructor.Mapper
{
    public class ShippingAddressMapperProfile : Profile
    {
        public ShippingAddressMapperProfile()
        {
            CreateMap<ShippingAddress, ShippingAddressRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ShippingAddress, ShippingAddressResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
