using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.ProductDetail
{
    public interface IProductDetailRepository : IRepository<EF.ProductDetail>
    {
    }
}
