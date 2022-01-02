using AutoMapper;
using CommercialSite.Common.DTOs.ProductProperty;
using CommercialSite.Common.Extensions;
using CommercialSite.Model.Entities;

namespace CommercialSite.API.Infrastructor.Mapper
{
    public class ProductPropertyMapperProfile : Profile
    {
        public ProductPropertyMapperProfile()
        {
            CreateMap<ProductProperty, ProductPropertyRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ProductProperty, ProductPropertyResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
