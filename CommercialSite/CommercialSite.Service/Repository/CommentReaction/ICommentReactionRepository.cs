using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.CommentReaction
{
    public interface ICommentReactionRepository : IRepository<EF.CommentReaction>
    {
    }
}
