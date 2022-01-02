using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.Product
{
    public interface IProductRepository : IRepository<EF.Product>
    {
    }
}
