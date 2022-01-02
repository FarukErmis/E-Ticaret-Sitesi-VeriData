using AutoMapper;
using CommercialSite.Common.DTOs.ProductDetail;
using CommercialSite.Common.Extensions;
using CommercialSite.Model.Entities;

namespace CommercialSite.API.Infrastructor.Mapper
{
    public class ProductDetailMapperProfile : Profile
    {
        public ProductDetailMapperProfile()
        {
            CreateMap<ProductDetail, ProductDetailRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ProductDetail, ProductDetailResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
