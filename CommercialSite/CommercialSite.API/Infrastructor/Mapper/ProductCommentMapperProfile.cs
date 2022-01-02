using AutoMapper;
using CommercialSite.Common.DTOs.ProductComment;
using CommercialSite.Common.Extensions;
using CommercialSite.Model.Entities;

namespace CommercialSite.API.Infrastructor.Mapper
{
    public class ProductCommentMapperProfile : Profile
    {
        public ProductCommentMapperProfile()
        {
            CreateMap<ProductComment, ProductCommentRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ProductComment, ProductCommentResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
