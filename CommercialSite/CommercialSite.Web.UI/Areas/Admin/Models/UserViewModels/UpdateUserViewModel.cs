using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CommercialSite.Web.UI.Areas.Admin.Models.UserViewModels
{
    public class UpdateUserViewModel
    {
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

        public static implicit operator UpdateUserViewModel(UserResponse v)
        {
            throw new NotImplementedException();
        }
    }
}
