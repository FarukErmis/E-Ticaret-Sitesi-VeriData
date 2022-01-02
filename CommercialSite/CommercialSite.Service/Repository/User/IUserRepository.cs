using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.User
{
    public interface IUserRepository : IRepository<EF.User>
    {
    }
}
