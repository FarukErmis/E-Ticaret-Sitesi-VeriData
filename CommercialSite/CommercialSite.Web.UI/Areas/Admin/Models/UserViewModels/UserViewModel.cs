using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.Areas.Admin.Models.UserDetailViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.UserViewModels
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            UserDetails = new HashSet<UserDetailViewModel>();
        }
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Title { get; set; }
        public string AvatarUrl { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string LastIPAddress { get; set; }
        public DateTime? LastLogin { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public ICollection<UserDetailViewModel> UserDetails { get; set; }
    }
}
