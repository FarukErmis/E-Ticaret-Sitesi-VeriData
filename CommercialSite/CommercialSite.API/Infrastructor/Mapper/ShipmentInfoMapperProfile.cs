using AutoMapper;
using CommercialSite.Common.DTOs.ShipmentInfo;
using CommercialSite.Common.Extensions;
using CommercialSite.Model.Entities;

namespace CommercialSite.API.Infrastructor.Mapper
{
    public class ShipmentInfoMapperProfile : Profile
    {
        public ShipmentInfoMapperProfile()
        {
            CreateMap<ShipmentInfo, ShipmentInfoRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ShipmentInfo, ShipmentInfoResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
