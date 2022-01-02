using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.FavoriteProduct
{
    public interface IFavoriteProductRepository : IRepository<EF.FavoriteProduct>
    {
    }
}
