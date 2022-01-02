using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.ShippingSetting
{
    public interface IShippingSettingRepository : IRepository<EF.ShippingSetting>
    {
    }
}
