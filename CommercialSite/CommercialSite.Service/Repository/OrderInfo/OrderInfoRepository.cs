using CommercialSite.Model.Context;
using CommercialSite.Service.Repository.Base;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.OrderInfo
{
    public class OrderInfoRepository : Repository<EF.OrderInfo>, IOrderInfoRepository
    {
        private readonly DataContext _context;
        public OrderInfoRepository(DataContext context)
            : base(context)
        {
            _context = context;
            //_context.Set<EF.Post>().Add(new EF.Post { });
            //this.Add();
            //this.Update();
            //this.Table.Where
            //this.TableNoTracking
        }
    }
}
