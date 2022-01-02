using CommercialSite.Model.Context;
using CommercialSite.Service.Repository.Base;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.ShippingSetting
{
    public class ShippingSettingRepository : Repository<EF.ShippingSetting>, IShippingSettingRepository
    {
        private readonly DataContext _context;
        public ShippingSettingRepository(DataContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
