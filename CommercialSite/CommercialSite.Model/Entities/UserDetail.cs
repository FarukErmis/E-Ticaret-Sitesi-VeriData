using CommercialSite.Core.Entity;
using CommercialSite.Model.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Entities
{
    public class UserDetail : CoreEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public string TCKN { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender? Gender { get; set; }

        public User CreatedUserDetail { get; set; }
        public User UpdatedUserDetail { get; set; }
    }
}
