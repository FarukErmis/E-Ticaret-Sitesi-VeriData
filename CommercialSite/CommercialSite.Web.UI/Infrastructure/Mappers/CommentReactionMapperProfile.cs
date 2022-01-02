using AutoMapper;
using CommercialSite.Common.DTOs.CommentReaction;
using CommercialSite.Common.Extensions;
using CommercialSite.Web.UI.Areas.Admin.Models.CommentReactionViewModels;

namespace CommercialSite.Web.UI.Infrastructure.Mappers
{
    public class CommentReactionMapperProfile : Profile
    {
        public CommentReactionMapperProfile()
        {
            CreateMap<CommentReactionViewModel, CommentReactionRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CommentReactionViewModel, CommentReactionResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CreateCommentReactionViewModel, CommentReactionRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CreateCommentReactionViewModel, CommentReactionResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<UpdateCommentReactionViewModel, CommentReactionRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<UpdateCommentReactionViewModel, CommentReactionResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
