using AutoMapper;
using CommercialSite.Common.DTOs.ShippingAddress;
using CommercialSite.Common.Extensions;
using CommercialSite.Web.UI.Areas.User.Models.ShippingAddressViewModels;

namespace CommercialSite.Web.UI.Infrastructure.Mappers
{
    public class ShippingAddressMapperProfile : Profile
    {
        public ShippingAddressMapperProfile()
        {
            CreateMap<ShippingAddressViewModel, ShippingAddressRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ShippingAddressViewModel, ShippingAddressResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CreateShippingAddressViewModel, ShippingAddressRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CreateShippingAddressViewModel, ShippingAddressResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<UpdateShippingAddressViewModel, ShippingAddressRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<UpdateShippingAddressViewModel, ShippingAddressResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
