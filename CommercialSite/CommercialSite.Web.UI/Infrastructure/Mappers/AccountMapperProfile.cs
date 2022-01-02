using AutoMapper;
using CommercialSite.Common.DTOs.Login;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Extensions;
using CommercialSite.Web.UI.Models.AccountViewModels;

namespace CommercialSite.Web.UI.Infrastructure.Mappers
{
    public class AccountMapperProfile : Profile
    {
        public AccountMapperProfile()
        {
            CreateMap<LoginViewModel, LoginRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<LoginViewModel, UserResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

        }
    }
}
