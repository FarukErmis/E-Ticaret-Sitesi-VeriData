using AutoMapper;
using CommercialSite.Common.DTOs.ShippingSetting;
using CommercialSite.Common.Extensions;
using CommercialSite.Web.UI.Areas.Admin.Models.ShippingSettingViewModels;

namespace CommercialSite.Web.UI.Infrastructure.Mappers
{
    public class ShippingSettingMapperProfile : Profile
    {
        public ShippingSettingMapperProfile()
        {
            CreateMap<ShippingSettingViewModel, ShippingSettingRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ShippingSettingViewModel, ShippingSettingResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CreateShippingSettingViewModel, ShippingSettingRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CreateShippingSettingViewModel, ShippingSettingResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<UpdateShippingSettingViewModel, ShippingSettingRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<UpdateShippingSettingViewModel, ShippingSettingResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
