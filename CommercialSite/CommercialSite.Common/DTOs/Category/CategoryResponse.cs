using CommercialSite.Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.Category
{
    public class CategoryResponse : BaseDto
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
