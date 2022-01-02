using AutoMapper;
using CommercialSite.Common.DTOs.BillingAddress;
using CommercialSite.Common.Extensions;
using CommercialSite.Web.UI.Areas.User.Models.BillingAddressViewModels;

namespace CommercialSite.Web.UI.Infrastructure.Mappers
{
    public class BillingAddressMapperProfile : Profile
    {
        public BillingAddressMapperProfile()
        {
            CreateMap<BillingAddressViewModel, BillingAddressRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<BillingAddressViewModel, BillingAddressResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CreateBillingAddressViewModel, BillingAddressRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CreateBillingAddressViewModel, BillingAddressResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<UpdateBillingAddressViewModel, BillingAddressRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<UpdateBillingAddressViewModel, BillingAddressResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
