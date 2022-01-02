using CommercialSite.Common.DTOs.Base;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Common.DTOs.UserDetail
{
    public class UserDetailResponse : BaseDto
    {
        public Guid UserId { get; set; }
        public UserResponse User { get; set; }
        public string TCKN { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender? Gender { get; set; }
    }
}
