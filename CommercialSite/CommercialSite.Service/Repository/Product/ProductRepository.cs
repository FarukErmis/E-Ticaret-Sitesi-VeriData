using CommercialSite.Model.Context;
using CommercialSite.Service.Repository.Base;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.Product
{
    public class ProductRepository : Repository<EF.Product>, IProductRepository
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
