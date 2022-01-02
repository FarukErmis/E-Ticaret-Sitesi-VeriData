﻿using CommercialSite.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Areas.User.Models.ShipmentInfoViewModels
{
    public class UpdateShipmentInfoViewModel
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public string ShipmentName { get; set; }
    }
}
