using AutoMapper;
using CommercialSite.Common.DTOs.OrderInfo;
using CommercialSite.Common.Extensions;
using CommercialSite.Model.Entities;

namespace CommercialSite.API.Infrastructor.Mapper
{
    public class OrderInfoMapperProfile : Profile
    {
        public OrderInfoMapperProfile()
        {
            CreateMap<OrderInfo, OrderInfoRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<OrderInfo, OrderInfoResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
