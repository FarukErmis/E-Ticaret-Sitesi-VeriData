using CommercialSite.Model.Context;
using CommercialSite.Service.Repository.Base;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.User
{
    public class UserRepository : Repository<EF.User>, IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
