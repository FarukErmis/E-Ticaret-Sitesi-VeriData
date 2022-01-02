using CommercialSite.Model.Context;
using CommercialSite.Service.Repository.Base;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.ProductComment
{
    public class ProductCommentRepository : Repository<EF.ProductComment>, IProductCommentRepository
    {
        private readonly DataContext _context;
        public ProductCommentRepository(DataContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
