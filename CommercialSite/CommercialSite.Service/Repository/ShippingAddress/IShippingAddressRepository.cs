using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.ShippingAddress
{
    public interface IShippingAddressRepository : IRepository<EF.ShippingAddress>
    {
    }
}
