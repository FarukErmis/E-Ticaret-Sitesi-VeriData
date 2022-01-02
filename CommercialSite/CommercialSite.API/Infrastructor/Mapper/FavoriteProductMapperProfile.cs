using AutoMapper;
using CommercialSite.Common.DTOs.FavoriteProduct;
using CommercialSite.Common.Extensions;
using CommercialSite.Model.Entities;

namespace CommercialSite.API.Infrastructor.Mapper
{
    public class FavoriteProductMapperProfile : Profile
    {
        public FavoriteProductMapperProfile()
        {
            CreateMap<FavoriteProduct, FavoriteProductRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<FavoriteProduct, FavoriteProductResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
