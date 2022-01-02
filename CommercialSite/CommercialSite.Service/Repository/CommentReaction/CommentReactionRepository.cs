using CommercialSite.Model.Context;
using CommercialSite.Service.Repository.Base;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.CommentReaction
{
    public class CommentReactionRepository : Repository<EF.CommentReaction>, ICommentReactionRepository
    {
        private readonly DataContext _context;
        public CommentReactionRepository(DataContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
