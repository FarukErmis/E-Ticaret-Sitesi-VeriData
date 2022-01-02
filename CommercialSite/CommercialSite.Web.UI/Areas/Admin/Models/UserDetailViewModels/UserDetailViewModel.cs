using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.Admin.Models.UserViewModels;
using System;

namespace CommercialSite.Web.UI.Areas.Admin.Models.UserDetailViewModels
{
    public class UserDetailViewModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public UserViewModel User { get; set; }
        public string TCKN { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender? Gender { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
