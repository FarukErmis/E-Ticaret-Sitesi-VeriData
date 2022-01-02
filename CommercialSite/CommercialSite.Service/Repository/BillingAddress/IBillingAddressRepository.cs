using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.BillingAddress
{
    public interface IBillingAddressRepository : IRepository<EF.BillingAddress>
    {
    }
}
