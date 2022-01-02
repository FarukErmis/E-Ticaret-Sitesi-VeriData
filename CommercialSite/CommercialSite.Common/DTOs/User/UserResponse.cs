using CommercialSite.Common.DTOs.Base;
using CommercialSite.Common.Models;
using System;

namespace CommercialSite.Common.DTOs.User
{
    public class UserResponse : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string AvatarUrl { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LastIPAddress { get; set; }
        public DateTime? LastLogin { get; set; }
        public GetAccessToken AccessToken { get; set; }
    }
}
