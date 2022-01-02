using AutoMapper;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.DTOs.UserDetail;
using CommercialSite.Common.Extensions;
using CommercialSite.Model.Entities;

namespace CommercialSite.API.Infrastructor.Mapper
{
    public class UserDetailMapperProfile : Profile
    {
        public UserDetailMapperProfile()
        {
            CreateMap<UserDetail, UserDetailRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<UserDetail, UserDetailResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
