using CommercialSite.Model.Context;
using CommercialSite.Service.Repository.Base;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.ProductImage
{
    public class ProductImageRepository : Repository<EF.ProductImage>, IProductImageRepository
    {
        private readonly DataContext _context;
        public ProductImageRepository(DataContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
