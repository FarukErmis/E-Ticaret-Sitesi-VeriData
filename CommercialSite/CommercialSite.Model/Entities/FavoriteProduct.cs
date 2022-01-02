using CommercialSite.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Entities
{
    public class FavoriteProduct : CoreEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public User CreatedUserFavoriteProduct { get; set; }
        public User UpdatedUserFavoriteProduct { get; set; }
    }
}
