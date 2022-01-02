using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.OrderInfo
{
    public interface IOrderInfoRepository : IRepository<EF.OrderInfo>
    {
    }
}
