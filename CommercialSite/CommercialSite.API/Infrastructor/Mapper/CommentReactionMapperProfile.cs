using AutoMapper;
using CommercialSite.Common.DTOs.CommentReaction;
using CommercialSite.Common.Extensions;
using CommercialSite.Model.Entities;

namespace CommercialSite.API.Infrastructor.Mapper
{
    public class CommentReactionMapperProfile : Profile
    {
        public CommentReactionMapperProfile()
        {
            CreateMap<CommentReaction, CommentReactionRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CommentReaction, CommentReactionResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllOtherMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
