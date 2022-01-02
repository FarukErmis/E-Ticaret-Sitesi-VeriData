using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.ShipmentInfo
{
    public interface IShipmentInfoRepository : IRepository<EF.ShipmentInfo>
    {
    }
}
