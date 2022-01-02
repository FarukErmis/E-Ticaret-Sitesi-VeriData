using CommercialSite.Model.Context;
using CommercialSite.Service.Repository.Base;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.ProductDetail
{
    public class ProductDetailRepository : Repository<EF.ProductDetail>, IProductDetailRepository
    {
        private readonly DataContext _context;
        public ProductDetailRepository(DataContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
