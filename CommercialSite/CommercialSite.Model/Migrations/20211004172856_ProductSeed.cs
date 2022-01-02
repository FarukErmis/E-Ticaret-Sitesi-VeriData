using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommercialSite.Model.Migrations
{
    public partial class ProductSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedDate", "CreatedIp", "CreatedUserId", "Description", "DiscountPrice", "ProductName", "Rate", "ReviewNumber", "Status", "UpdatedDate", "UpdatedIp", "UpdatedUserId", "WithoutDiscountPrice" },
                values: new object[,]
                {
                    { new Guid("a4518427-e6f0-46bd-bbbd-4dcdaa92966e"), new Guid("6520d7be-be4d-4b0d-a222-7e3d90c42de1"), new Guid("21f8242e-dd3a-4280-85ad-3bce8bbe4c8c"), null, null, null, null, 5.1989999999999998, "Philips 50PUS7805 50 Inç 126 Ekran Uydu Alıcılı 4K Ultra HD LED Smart TV", 4, 0, 1, null, null, null, 8.1989999999999998 },
                    { new Guid("e55ae9f3-888d-4c69-a0e7-4403a8292d95"), new Guid("076bff1f-6c72-4eca-9bf9-1fe491a108b4"), new Guid("afa8a153-6eed-4ad2-a453-dc6d2f86caab"), null, null, null, null, 11.249000000000001, "Samsung Galaxy Note 20 Ultra 256 GB (Samsung Türkiye Garantili)", 4, 0, 1, null, null, null, 12.298999999999999 },
                    { new Guid("67614fef-8f67-4ba5-af0d-f35479d003f2"), new Guid("ad3869c4-0631-4d56-8fc3-12b9afd7d40a"), new Guid("afa8a153-6eed-4ad2-a453-dc6d2f86caab"), null, null, null, null, 4.2990000000000004, "Xiaomi Redmi Note 10 Pro 128 GB 8 GB RAM (Xiaomi Türkiye Garantili)", 4, 0, 1, null, null, null, 3.7989999999999999 },
                    { new Guid("49669332-44e1-4696-84c0-9ab229061315"), new Guid("14534656-c0d2-44cf-922c-6fc83a21c203"), new Guid("afa8a153-6eed-4ad2-a453-dc6d2f86caab"), null, null, null, null, 3.3180000000000001, "Oppo Reno 4 Lite 128 GB (Oppo Türkiye Garantili)", 4, 0, 1, null, null, null, 3.5990000000000002 },
                    { new Guid("ebf25e2d-15e5-4133-ad82-156f83f4ce96"), new Guid("e49c6a75-5835-471e-918a-3345bbb26809"), new Guid("afa8a153-6eed-4ad2-a453-dc6d2f86caab"), null, null, null, null, 1.5489999999999999, "Reeder P13 Blue Max 64 GB (Reeder Türkiye Garantili)", 3, 0, 1, null, null, null, 2.0489999999999999 },
                    { new Guid("44926cd7-1678-4808-a2b0-df95c6f865fc"), new Guid("1a7c509d-42e2-4213-a944-212f07222084"), new Guid("21f8242e-dd3a-4280-85ad-3bce8bbe4c8c"), null, null, null, null, 4.399, "LG 43UN71006LB 43 Inç 108 Ekran Uydu Alıcılı 4K Ultra HD Smart LED TV", 4, 0, 1, null, null, null, 5.9989999999999997 },
                    { new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), new Guid("2cb8bfab-ff82-41bd-bf39-84d3e5b6ef89"), new Guid("9361933a-b73c-4d1d-9dd1-ecfc816b3e6d"), null, null, null, null, 12.199, "Acer Nitro 5 Intel Core i7 10750H", 4, 0, 1, null, null, null, 14.999000000000001 },
                    { new Guid("b9b5381c-de81-4953-a7ee-9a782b9652da"), new Guid("af6273bb-dc30-4a61-9aeb-8225636f564a"), new Guid("8d0de41d-191a-469f-8909-61c169df2d8e"), null, null, null, null, 1.829, "Lenovo TAB M10 TB-X606F 64GB 10.3 Wi Fi Tablet Gri ZA5T0215TR", 4, 0, 1, null, null, null, 2.9990000000000001 },
                    { new Guid("05e3d510-6866-47b9-ad75-3cf2fd330c9c"), new Guid("076bff1f-6c72-4eca-9bf9-1fe491a108b4"), new Guid("8d0de41d-191a-469f-8909-61c169df2d8e"), null, null, null, null, 4.899, "Samsung Galaxy Tab S7 SM-T870 128 GB Tablet", 4, 0, 1, null, null, null, 5.7990000000000004 },
                    { new Guid("2322717a-d36d-4299-af9f-2b6faedd1423"), new Guid("af6273bb-dc30-4a61-9aeb-8225636f564a"), new Guid("9361933a-b73c-4d1d-9dd1-ecfc816b3e6d"), null, null, null, null, 7.5990000000000002, "Lenovo IdeaPad Gaming 3 AMD Ryzen 5 4600H", 3, 0, 1, null, null, null, 11.109 },
                    { new Guid("c15eb71a-0120-434c-bbad-8011d796b392"), new Guid("2cb8bfab-ff82-41bd-bf39-84d3e5b6ef89"), new Guid("9361933a-b73c-4d1d-9dd1-ecfc816b3e6d"), null, null, null, null, 17.998999999999999, "Acer Predator Triton 500 Intel Core i7 10750H", 5, 0, 1, null, null, null, 23.959 },
                    { new Guid("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"), new Guid("877bdb84-f2f3-4143-aae4-b1a5e6103781"), new Guid("afa8a153-6eed-4ad2-a453-dc6d2f86caab"), null, null, null, null, 13.999000000000001, "iPhone XS Max 256 GB", 4, 0, 1, null, null, null, 14.999000000000001 },
                    { new Guid("a7630777-3514-46e6-8f46-ff84d48a32a8"), new Guid("e49c6a75-5835-471e-918a-3345bbb26809"), new Guid("8d0de41d-191a-469f-8909-61c169df2d8e"), null, null, null, null, 1.399, "Reeder M10 Blue Max 64GB 4G LTE", 4, 0, 1, null, null, null, 2.2989999999999999 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
