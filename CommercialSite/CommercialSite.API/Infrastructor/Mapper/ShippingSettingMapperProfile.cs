using AutoMapper;
using CommercialSite.Common.DTOs.ShippingSetting;
using CommercialSite.Common.Extensions;
using CommercialSite.Model.Entities;

namespace CommercialSite.API.Infrastructor.Mapper
{
    public class ShippingSettingMapperProfile : Profile
    {
        public ShippingSettingMapperProfile()
        {
            CreateMap<ShippingSetting, ShippingSettingRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ShippingSetting, ShippingSettingResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
