using CommercialSite.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.UserDetailViewModels
{
    public class UpdateUserDetailViewModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string TCKN { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender? Gender { get; set; }
        public Status Status { get; set; }
    }
}
