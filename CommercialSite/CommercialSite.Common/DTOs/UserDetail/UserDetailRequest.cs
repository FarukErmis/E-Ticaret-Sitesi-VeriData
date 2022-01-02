using CommercialSite.Common.DTOs.Base;
using CommercialSite.Common.Enums;
using System;

namespace CommercialSite.Common.DTOs.UserDetail
{
    public class UserDetailRequest : BaseDto
    {
        public Guid UserId { get; set; }
        public string TCKN { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender? Gender { get; set; }
    }
}
