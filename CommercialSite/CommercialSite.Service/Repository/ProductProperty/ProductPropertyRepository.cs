using CommercialSite.Model.Context;
using CommercialSite.Service.Repository.Base;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.ProductProperty
{
    public class ProductPropertyRepository : Repository<EF.ProductProperty>, IProductPropertyRepository
    {
        private readonly DataContext _context;
        public ProductPropertyRepository(DataContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
