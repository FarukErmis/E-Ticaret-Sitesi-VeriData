using CommercialSite.Common.Models;
using System;

namespace CommercialSite.Web.UI.Infrastructure.Helpers
{
    public class CookieModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImagePath { get; set; }
        public GetAccessToken AccessToken { get; set; }
    }
}
