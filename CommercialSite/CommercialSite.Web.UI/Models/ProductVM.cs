using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Models
{
    public class ProductVM
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public double? TotalPrice { get; set; }
        public double TrullyPrice { get; set; }
        public double? Discount { get; set; }
        public double? Rates { get; set; }
        public bool? IsShippingFree { get; set; }
        public short Quantity { get; set; }
    }
}
