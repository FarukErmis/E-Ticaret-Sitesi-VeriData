using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.ProductImage
{
    public interface IProductImageRepository : IRepository<EF.ProductImage>
    {
    }
}
