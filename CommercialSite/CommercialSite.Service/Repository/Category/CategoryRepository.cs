using CommercialSite.Model.Context;
using CommercialSite.Service.Repository.Base;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.Category
{
    public class CategoryRepository : Repository<EF.Category>, ICategoryRepository
    {
        private readonly DataContext _context;
        public CategoryRepository(DataContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
