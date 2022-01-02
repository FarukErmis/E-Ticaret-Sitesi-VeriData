using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.ProductProperty
{
    public interface IProductPropertyRepository : IRepository<EF.ProductProperty>
    {
    }
}
