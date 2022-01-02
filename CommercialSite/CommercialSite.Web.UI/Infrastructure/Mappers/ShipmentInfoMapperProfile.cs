using AutoMapper;
using CommercialSite.Common.DTOs.ShipmentInfo;
using CommercialSite.Common.Extensions;
using CommercialSite.Web.UI.Areas.User.Models.ShipmentInfoViewModels;

namespace CommercialSite.Web.UI.Infrastructure.Mappers
{
    public class ShipmentInfoMapperProfile : Profile
    {
        public ShipmentInfoMapperProfile()
        {
            CreateMap<ShipmentInfoViewModel, ShipmentInfoRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ShipmentInfoViewModel, ShipmentInfoResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CreateShipmentInfoViewModel, ShipmentInfoRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CreateShipmentInfoViewModel, ShipmentInfoResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<UpdateShipmentInfoViewModel, ShipmentInfoRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<UpdateShipmentInfoViewModel, ShipmentInfoResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
