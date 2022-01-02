using CommercialSite.Model.Context;
using CommercialSite.Service.Repository.Base;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.ShippingAddress
{
    public class ShippingAddressRepository : Repository<EF.ShippingAddress>, IShippingAddressRepository
    {
        private readonly DataContext _context;
        public ShippingAddressRepository(DataContext context)
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
