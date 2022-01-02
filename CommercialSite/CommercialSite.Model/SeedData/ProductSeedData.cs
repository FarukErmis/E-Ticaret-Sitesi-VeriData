using CommercialSite.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.SeedData
{
    public class ProductSeedData : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Acer Nitro 5 Intel Core i7 10750H",
                    CategoryId = Guid.Parse("9361933a-b73c-4d1d-9dd1-ecfc816b3e6d"),
                    BrandId = Guid.Parse("2cb8bfab-ff82-41bd-bf39-84d3e5b6ef89"),
                    WithoutDiscountPrice = 14.999,
                    DiscountPrice = 12.199,
                    Rate = (int?)4.5,
                    ReviewNumber = 0
                });
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Acer Predator Triton 500 Intel Core i7 10750H",
                    CategoryId = Guid.Parse("9361933a-b73c-4d1d-9dd1-ecfc816b3e6d"),
                    BrandId = Guid.Parse("2cb8bfab-ff82-41bd-bf39-84d3e5b6ef89"),
                    WithoutDiscountPrice = 23.959,
                    DiscountPrice = 17.999,
                    Rate = (int?)5,
                    ReviewNumber = 0
                });
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Lenovo IdeaPad Gaming 3 AMD Ryzen 5 4600H",
                    CategoryId = Guid.Parse("9361933a-b73c-4d1d-9dd1-ecfc816b3e6d"),
                    BrandId = Guid.Parse("af6273bb-dc30-4a61-9aeb-8225636f564a"),
                    WithoutDiscountPrice = 11.109,
                    DiscountPrice = 7.599,
                    Rate = (int?)3.5,
                    ReviewNumber = 0
                });
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Samsung Galaxy Tab S7 SM-T870 128 GB Tablet",
                    CategoryId = Guid.Parse("8d0de41d-191a-469f-8909-61c169df2d8e"),
                    BrandId = Guid.Parse("076bff1f-6c72-4eca-9bf9-1fe491a108b4"),
                    WithoutDiscountPrice = 5.799,
                    DiscountPrice = 4.899,
                    Rate = (int?)4.7,
                    ReviewNumber = 0
                });
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Lenovo TAB M10 TB-X606F 64GB 10.3 Wi Fi Tablet Gri ZA5T0215TR",
                    CategoryId = Guid.Parse("8d0de41d-191a-469f-8909-61c169df2d8e"),
                    BrandId = Guid.Parse("af6273bb-dc30-4a61-9aeb-8225636f564a"),
                    WithoutDiscountPrice = 2.999,
                    DiscountPrice = 1.829,
                    Rate = (int?)4.2,
                    ReviewNumber = 0
                });
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Reeder M10 Blue Max 64GB 4G LTE",
                    CategoryId = Guid.Parse("8d0de41d-191a-469f-8909-61c169df2d8e"),
                    BrandId = Guid.Parse("e49c6a75-5835-471e-918a-3345bbb26809"),
                    WithoutDiscountPrice = 2.299,
                    DiscountPrice = 1.399,
                    Rate = (int?)4,
                    ReviewNumber = 0
                });
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "LG 43UN71006LB 43 Inç 108 Ekran Uydu Alıcılı 4K Ultra HD Smart LED TV",
                    CategoryId = Guid.Parse("21f8242e-dd3a-4280-85ad-3bce8bbe4c8c"),
                    BrandId = Guid.Parse("1a7c509d-42e2-4213-a944-212f07222084"),
                    WithoutDiscountPrice = 5.999,
                    DiscountPrice = 4.399,
                    Rate = (int?)4.7,
                    ReviewNumber = 0
                });
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Philips 50PUS7805 50 Inç 126 Ekran Uydu Alıcılı 4K Ultra HD LED Smart TV",
                    CategoryId = Guid.Parse("21f8242e-dd3a-4280-85ad-3bce8bbe4c8c"),
                    BrandId = Guid.Parse("6520d7be-be4d-4b0d-a222-7e3d90c42de1"),
                    WithoutDiscountPrice = 8.199,
                    DiscountPrice = 5.199,
                    Rate = (int?)4.6,
                    ReviewNumber = 0
                });
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Reeder P13 Blue Max 64 GB (Reeder Türkiye Garantili)",
                    CategoryId = Guid.Parse("afa8a153-6eed-4ad2-a453-dc6d2f86caab"),
                    BrandId = Guid.Parse("e49c6a75-5835-471e-918a-3345bbb26809"),
                    WithoutDiscountPrice = 2.049,
                    DiscountPrice = 1.549,
                    Rate = (int?)3.6,
                    ReviewNumber = 0
                });
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Oppo Reno 4 Lite 128 GB (Oppo Türkiye Garantili)",
                    CategoryId = Guid.Parse("afa8a153-6eed-4ad2-a453-dc6d2f86caab"),
                    BrandId = Guid.Parse("14534656-c0d2-44cf-922c-6fc83a21c203"),
                    WithoutDiscountPrice = 3.599,
                    DiscountPrice = 3.318,
                    Rate = (int?)4.4,
                    ReviewNumber = 0
                });
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Xiaomi Redmi Note 10 Pro 128 GB 8 GB RAM (Xiaomi Türkiye Garantili)",
                    CategoryId = Guid.Parse("afa8a153-6eed-4ad2-a453-dc6d2f86caab"),
                    BrandId = Guid.Parse("ad3869c4-0631-4d56-8fc3-12b9afd7d40a"),
                    WithoutDiscountPrice = 3.799,
                    DiscountPrice = 4.299,
                    Rate = (int?)4.6,
                    ReviewNumber = 0
                });
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Samsung Galaxy Note 20 Ultra 256 GB (Samsung Türkiye Garantili)",
                    CategoryId = Guid.Parse("afa8a153-6eed-4ad2-a453-dc6d2f86caab"),
                    BrandId = Guid.Parse("076bff1f-6c72-4eca-9bf9-1fe491a108b4"),
                    WithoutDiscountPrice = 12.299,
                    DiscountPrice = 11.249,
                    Rate = (int?)4.5,
                    ReviewNumber = 0
                });
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "iPhone XS Max 256 GB",
                    CategoryId = Guid.Parse("afa8a153-6eed-4ad2-a453-dc6d2f86caab"),
                    BrandId = Guid.Parse("877bdb84-f2f3-4143-aae4-b1a5e6103781"),
                    WithoutDiscountPrice = 14.999,
                    DiscountPrice = 13.999,
                    Rate = (int?)4.7,
                    ReviewNumber = 0
                });
            
        }
    }
}
