using CommercialSite.Model.Context;
using CommercialSite.Service.Repository.Base;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.UserDetail
{
    public class UserDetailRepository : Repository<EF.UserDetail>, IUserDetailRepository
    {
        private readonly DataContext _context;
        public UserDetailRepository(DataContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
