using CommercialSite.Core.Entity.Enums;
using CommercialSite.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.SeedData
{
    public class ProductImageSeedData : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   ImageUrl = "1.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   ImageUrl = "2.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   ImageUrl = "3.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("c15eb71a-0120-434c-bbad-8011d796b392"),
                   Status = Status.Active,
                   ImageUrl = "4.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("c15eb71a-0120-434c-bbad-8011d796b392"),
                   Status = Status.Active,
                   ImageUrl = "5.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("c15eb71a-0120-434c-bbad-8011d796b392"),
                   Status = Status.Active,
                   ImageUrl = "6.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("2322717a-d36d-4299-af9f-2b6faedd1423"),
                   Status = Status.Active,
                   ImageUrl = "7.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("2322717a-d36d-4299-af9f-2b6faedd1423"),
                   Status = Status.Active,
                   ImageUrl = "8.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("2322717a-d36d-4299-af9f-2b6faedd1423"),
                   Status = Status.Active,
                   ImageUrl = "9.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"),
                   Status = Status.Active,
                   ImageUrl = "10.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"),
                   Status = Status.Active,
                   ImageUrl = "11.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"),
                   Status = Status.Active,
                   ImageUrl = "12.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("b9b5381c-de81-4953-a7ee-9a782b9652da"),
                   Status = Status.Active,
                   ImageUrl = "13.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("b9b5381c-de81-4953-a7ee-9a782b9652da"),
                   Status = Status.Active,
                   ImageUrl = "14.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("44926cd7-1678-4808-a2b0-df95c6f865fc"),
                   Status = Status.Active,
                   ImageUrl = "15.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("44926cd7-1678-4808-a2b0-df95c6f865fc"),
                   Status = Status.Active,
                   ImageUrl = "16.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("44926cd7-1678-4808-a2b0-df95c6f865fc"),
                   Status = Status.Active,
                   ImageUrl = "17.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("44926cd7-1678-4808-a2b0-df95c6f865fc"),
                   Status = Status.Active,
                   ImageUrl = "18.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("44926cd7-1678-4808-a2b0-df95c6f865fc"),
                   Status = Status.Active,
                   ImageUrl = "19.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("49669332-44e1-4696-84c0-9ab229061315"),
                   Status = Status.Active,
                   ImageUrl = "20.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("49669332-44e1-4696-84c0-9ab229061315"),
                   Status = Status.Active,
                   ImageUrl = "21.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("49669332-44e1-4696-84c0-9ab229061315"),
                   Status = Status.Active,
                   ImageUrl = "22.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("a4518427-e6f0-46bd-bbbd-4dcdaa92966e"),
                   Status = Status.Active,
                   ImageUrl = "23.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("a4518427-e6f0-46bd-bbbd-4dcdaa92966e"),
                   Status = Status.Active,
                   ImageUrl = "24.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("a4518427-e6f0-46bd-bbbd-4dcdaa92966e"),
                   Status = Status.Active,
                   ImageUrl = "25.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("a7630777-3514-46e6-8f46-ff84d48a32a8"),
                   Status = Status.Active,
                   ImageUrl = "26.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("a7630777-3514-46e6-8f46-ff84d48a32a8"),
                   Status = Status.Active,
                   ImageUrl = "27.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("a7630777-3514-46e6-8f46-ff84d48a32a8"),
                   Status = Status.Active,
                   ImageUrl = "28.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("a7630777-3514-46e6-8f46-ff84d48a32a8"),
                   Status = Status.Active,
                   ImageUrl = "29.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("ebf25e2d-15e5-4133-ad82-156f83f4ce96"),
                   Status = Status.Active,
                   ImageUrl = "30.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("ebf25e2d-15e5-4133-ad82-156f83f4ce96"),
                   Status = Status.Active,
                   ImageUrl = "31.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("ebf25e2d-15e5-4133-ad82-156f83f4ce96"),
                   Status = Status.Active,
                   ImageUrl = "32.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("ebf25e2d-15e5-4133-ad82-156f83f4ce96"),
                   Status = Status.Active,
                   ImageUrl = "33.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("ebf25e2d-15e5-4133-ad82-156f83f4ce96"),
                   Status = Status.Active,
                   ImageUrl = "34.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("e55ae9f3-888d-4c69-a0e7-4403a8292d95"),
                   Status = Status.Active,
                   ImageUrl = "35.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("e55ae9f3-888d-4c69-a0e7-4403a8292d95"),
                   Status = Status.Active,
                   ImageUrl = "36.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("e55ae9f3-888d-4c69-a0e7-4403a8292d95"),
                   Status = Status.Active,
                   ImageUrl = "37.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("e55ae9f3-888d-4c69-a0e7-4403a8292d95"),
                   Status = Status.Active,
                   ImageUrl = "38.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("e55ae9f3-888d-4c69-a0e7-4403a8292d95"),
                   Status = Status.Active,
                   ImageUrl = "39.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("e55ae9f3-888d-4c69-a0e7-4403a8292d95"),
                   Status = Status.Active,
                   ImageUrl = "40.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("05e3d510-6866-47b9-ad75-3cf2fd330c9c"),
                   Status = Status.Active,
                   ImageUrl = "41.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("05e3d510-6866-47b9-ad75-3cf2fd330c9c"),
                   Status = Status.Active,
                   ImageUrl = "42.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("05e3d510-6866-47b9-ad75-3cf2fd330c9c"),
                   Status = Status.Active,
                   ImageUrl = "43.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("67614fef-8f67-4ba5-af0d-f35479d003f2"),
                   Status = Status.Active,
                   ImageUrl = "44.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("67614fef-8f67-4ba5-af0d-f35479d003f2"),
                   Status = Status.Active,
                   ImageUrl = "45.jpg"
               });
            builder.HasData(
               new ProductImage
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("67614fef-8f67-4ba5-af0d-f35479d003f2"),
                   Status = Status.Active,
                   ImageUrl = "46.jpg"
               });
        }
    }
}
