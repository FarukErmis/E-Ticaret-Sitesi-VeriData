using CommercialSite.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.Entities
{
    public class User : CoreEntity
    {
        public User()
        {
            CreatedUsers = new HashSet<User>();
            UpdatedUsers = new HashSet<User>();

            CreatedUserBrands = new HashSet<Brand>();
            UpdatedUserBrands = new HashSet<Brand>();

            CreatedUserCategories = new HashSet<Category>();
            UpdatedUserCategories = new HashSet<Category>();

            CreatedUserCommentReactions = new HashSet<CommentReaction>();
            UpdatedUserCommentReactions = new HashSet<CommentReaction>();

            CreatedUserProductComments = new HashSet<ProductComment>();
            UpdatedUserProductComments = new HashSet<ProductComment>();

            CreatedUserProducts = new HashSet<Product>();
            UpdatedUserProducts = new HashSet<Product>();

            CreatedUserProductDetails = new HashSet<ProductDetail>();
            UpdatedUserProductDetails = new HashSet<ProductDetail>();

            CreatedUserProductImages = new HashSet<ProductImage>();
            UpdatedUserProductImages = new HashSet<ProductImage>();

            CreatedUserProductProperties = new HashSet<ProductProperty>();
            UpdatedUserProductProperties = new HashSet<ProductProperty>();

            CreatedUserShippingSettings = new HashSet<ShippingSetting>();
            UpdatedUserShippingSettings = new HashSet<ShippingSetting>();

            CreatedUserDetails = new HashSet<UserDetail>();
            UpdatedUserDetails = new HashSet<UserDetail>();
            UserDetails = new HashSet<UserDetail>();

            CreatedUserFavoriteProducts = new HashSet<FavoriteProduct>();
            UpdatedUserFavoriteProducts = new HashSet<FavoriteProduct>();
            FavoriteProducts = new HashSet<FavoriteProduct>();

            CreatedUserShippingAddresses = new HashSet<ShippingAddress>();
            UpdatedUserShippingAddresses = new HashSet<ShippingAddress>();
            ShippingAddresses = new HashSet<ShippingAddress>();

            CreatedUserOrderInfos = new HashSet<OrderInfo>();
            UpdatedUserOrderInfos = new HashSet<OrderInfo>();
            OrderInfos = new HashSet<OrderInfo>();

            CreatedUserShipmentInfos = new HashSet<ShipmentInfo>();
            UpdatedUserShipmentInfos = new HashSet<ShipmentInfo>();
            ShipmentInfos = new HashSet<ShipmentInfo>();

            CreatedUserOrders = new HashSet<Order>();
            UpdatedUserOrders = new HashSet<Order>();
            Orders = new HashSet<Order>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string AvatarUrl { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LastIPAddress { get; set; }
        public DateTime? LastLogin { get; set; }


        public User CreatedUser { get; set; }
        public User UpdatedUser { get; set; }

        public ICollection<User> CreatedUsers { get; set; }
        public ICollection<User> UpdatedUsers { get; set; }

        public ICollection<Brand> CreatedUserBrands { get; set; }
        public ICollection<Brand> UpdatedUserBrands { get; set; }

        public ICollection<Category> CreatedUserCategories { get; set; }
        public ICollection<Category> UpdatedUserCategories { get; set; }

        public ICollection<CommentReaction> CreatedUserCommentReactions { get; set; }
        public ICollection<CommentReaction> UpdatedUserCommentReactions { get; set; }

        public ICollection<Product> CreatedUserProducts { get; set; }
        public ICollection<Product> UpdatedUserProducts { get; set; }

        public ICollection<ProductComment> CreatedUserProductComments { get; set; }
        public ICollection<ProductComment> UpdatedUserProductComments { get; set; }

        public ICollection<ProductDetail> CreatedUserProductDetails { get; set; }
        public ICollection<ProductDetail> UpdatedUserProductDetails { get; set; }

        public ICollection<ProductImage> CreatedUserProductImages { get; set; }
        public ICollection<ProductImage> UpdatedUserProductImages { get; set; }

        public ICollection<ProductProperty> CreatedUserProductProperties { get; set; }
        public ICollection<ProductProperty> UpdatedUserProductProperties { get; set; }

        public ICollection<ShippingSetting> CreatedUserShippingSettings { get; set; }
        public ICollection<ShippingSetting> UpdatedUserShippingSettings { get; set; }

        public ICollection<UserDetail> CreatedUserDetails { get; set; }
        public ICollection<UserDetail> UpdatedUserDetails { get; set; }
        public ICollection<UserDetail> UserDetails { get; set; }

        public ICollection<FavoriteProduct> CreatedUserFavoriteProducts { get; set; }
        public ICollection<FavoriteProduct> UpdatedUserFavoriteProducts { get; set; }
        public ICollection<FavoriteProduct> FavoriteProducts { get; set; }

        public ICollection<ShippingAddress> CreatedUserShippingAddresses { get; set; }
        public ICollection<ShippingAddress> UpdatedUserShippingAddresses { get; set; }
        public ICollection<ShippingAddress> ShippingAddresses { get; set; }

        public ICollection<BillingAddress> CreatedUserBillingAddresses { get; set; }
        public ICollection<BillingAddress> UpdatedUserBillingAddresses { get; set; }
        public ICollection<BillingAddress> BillingAddresses { get; set; }

        public ICollection<OrderInfo> CreatedUserOrderInfos { get; set; }
        public ICollection<OrderInfo> UpdatedUserOrderInfos { get; set; }
        public ICollection<OrderInfo> OrderInfos { get; set; }

        public ICollection<ShipmentInfo> CreatedUserShipmentInfos { get; set; }
        public ICollection<ShipmentInfo> UpdatedUserShipmentInfos { get; set; }
        public ICollection<ShipmentInfo> ShipmentInfos { get; set; }

        public ICollection<Order> CreatedUserOrders { get; set; }
        public ICollection<Order> UpdatedUserOrders { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
