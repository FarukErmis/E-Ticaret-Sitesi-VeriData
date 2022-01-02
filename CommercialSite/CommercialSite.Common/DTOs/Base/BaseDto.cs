using CommercialSite.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.Base
{
    public class BaseDto
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
    }
}
