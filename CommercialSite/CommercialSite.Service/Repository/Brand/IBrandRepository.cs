using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.Brand
{
    public interface IBrandRepository : IRepository<EF.Brand>
    {
    }
}
