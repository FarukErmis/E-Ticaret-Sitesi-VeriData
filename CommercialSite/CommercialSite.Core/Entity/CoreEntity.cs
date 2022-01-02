using CommercialSite.Core.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Core.Entity
{
    public class CoreEntity : IEntity<Guid>
    {
        public Guid Id { get ; set ; }
        public Status Status { get; set; }

        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedUserId { get; set; }
        public string CreatedIp { get; set; }

        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedUserId { get; set; }
        public string UpdatedIp { get; set; }
    }
}
