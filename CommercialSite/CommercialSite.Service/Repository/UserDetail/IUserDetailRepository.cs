using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.UserDetail
{
    public interface IUserDetailRepository : IRepository<EF.UserDetail>
    {
    }
}
