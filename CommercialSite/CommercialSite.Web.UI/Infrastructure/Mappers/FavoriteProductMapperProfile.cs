using AutoMapper;
using CommercialSite.Common.DTOs.FavoriteProduct;
using CommercialSite.Common.Extensions;
using CommercialSite.Web.UI.Areas.User.Models.FavoriteProductViewModels;

namespace CommercialSite.Web.UI.Infrastructure.Mappers
{
    public class FavoriteProductMapperProfile : Profile
    {
        public FavoriteProductMapperProfile()
        {
            CreateMap<FavoriteProductViewModel, FavoriteProductRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<FavoriteProductViewModel, FavoriteProductResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CreateFavoriteProductViewModel, FavoriteProductRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CreateFavoriteProductViewModel, FavoriteProductResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<UpdateFavoriteProductViewModel, FavoriteProductRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<UpdateFavoriteProductViewModel, FavoriteProductResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
