using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommercialSite.Model.Migrations
{
    public partial class ProductImageSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "CreatedIp", "CreatedUserId", "ImageUrl", "ProductId", "Status", "UpdatedDate", "UpdatedIp", "UpdatedUserId" },
                values: new object[,]
                {
                    { new Guid("f63b9499-2d5f-4b5d-a38e-98be99499d1d"), null, null, null, "25.jpg", new Guid("a4518427-e6f0-46bd-bbbd-4dcdaa92966e"), 1, null, null, null },
                    { new Guid("cbe4a630-8073-4274-9599-f48ef7ddefa6"), null, null, null, "26.jpg", new Guid("a7630777-3514-46e6-8f46-ff84d48a32a8"), 1, null, null, null },
                    { new Guid("eb602990-e869-42fd-bd43-3ec4050354df"), null, null, null, "27.jpg", new Guid("a7630777-3514-46e6-8f46-ff84d48a32a8"), 1, null, null, null },
                    { new Guid("6a1d2083-6bf6-42ce-985b-465da9321a30"), null, null, null, "28.jpg", new Guid("a7630777-3514-46e6-8f46-ff84d48a32a8"), 1, null, null, null },
                    { new Guid("0dd161b0-064d-47bf-8247-e07c4983b718"), null, null, null, "29.jpg", new Guid("a7630777-3514-46e6-8f46-ff84d48a32a8"), 1, null, null, null },
                    { new Guid("21f64517-7ed2-479f-919e-3a9c43ae0afc"), null, null, null, "30.jpg", new Guid("ebf25e2d-15e5-4133-ad82-156f83f4ce96"), 1, null, null, null },
                    { new Guid("67ec1d5b-7b96-484f-8156-989c17b158f4"), null, null, null, "31.jpg", new Guid("ebf25e2d-15e5-4133-ad82-156f83f4ce96"), 1, null, null, null },
                    { new Guid("992e4ca7-2e29-475a-a2b0-e48c5429d5ac"), null, null, null, "23.jpg", new Guid("a4518427-e6f0-46bd-bbbd-4dcdaa92966e"), 1, null, null, null },
                    { new Guid("5c685121-22f4-42af-9da9-e313565cd019"), null, null, null, "21.jpg", new Guid("49669332-44e1-4696-84c0-9ab229061315"), 1, null, null, null },
                    { new Guid("f46b6756-a368-400b-903a-c3c9af427923"), null, null, null, "20.jpg", new Guid("49669332-44e1-4696-84c0-9ab229061315"), 1, null, null, null },
                    { new Guid("0f1eca8a-8ab7-4293-a6c7-5a1d971e4559"), null, null, null, "19.jpg", new Guid("44926cd7-1678-4808-a2b0-df95c6f865fc"), 1, null, null, null },
                    { new Guid("56ea9236-6e23-40df-a038-6011d839f662"), null, null, null, "24.jpg", new Guid("a4518427-e6f0-46bd-bbbd-4dcdaa92966e"), 1, null, null, null },
                    { new Guid("090c06ef-9c1b-4c7e-8954-7730512187c4"), null, null, null, "22.jpg", new Guid("49669332-44e1-4696-84c0-9ab229061315"), 1, null, null, null },
                    { new Guid("0bcf7c9c-8f21-4dae-9b03-cafff49733f9"), null, null, null, "34.jpg", new Guid("ebf25e2d-15e5-4133-ad82-156f83f4ce96"), 1, null, null, null },
                    { new Guid("b166eeee-d7cb-442d-aae6-50086d28f394"), null, null, null, "33.jpg", new Guid("ebf25e2d-15e5-4133-ad82-156f83f4ce96"), 1, null, null, null },
                    { new Guid("873ebf94-cc77-41ed-80c2-5f58b9ca4db4"), null, null, null, "18.jpg", new Guid("44926cd7-1678-4808-a2b0-df95c6f865fc"), 1, null, null, null },
                    { new Guid("17206554-7f57-467d-8334-f46daf2c4158"), null, null, null, "35.jpg", new Guid("e55ae9f3-888d-4c69-a0e7-4403a8292d95"), 1, null, null, null },
                    { new Guid("99afd771-8d67-4d4c-ace5-d9f79a60aad4"), null, null, null, "36.jpg", new Guid("e55ae9f3-888d-4c69-a0e7-4403a8292d95"), 1, null, null, null },
                    { new Guid("4940ce24-02fd-4641-a4d3-8a4dcdf17745"), null, null, null, "37.jpg", new Guid("e55ae9f3-888d-4c69-a0e7-4403a8292d95"), 1, null, null, null },
                    { new Guid("dbf19c1b-22a2-4e14-8b07-2d93b5532be5"), null, null, null, "38.jpg", new Guid("e55ae9f3-888d-4c69-a0e7-4403a8292d95"), 1, null, null, null },
                    { new Guid("54ff0a8c-0f92-4c8e-b6e0-9c88240a8953"), null, null, null, "39.jpg", new Guid("e55ae9f3-888d-4c69-a0e7-4403a8292d95"), 1, null, null, null },
                    { new Guid("67ccb58d-fd0b-4de0-b418-b752df117a26"), null, null, null, "40.jpg", new Guid("e55ae9f3-888d-4c69-a0e7-4403a8292d95"), 1, null, null, null },
                    { new Guid("7ce8c3ea-7231-4357-bb96-8d2763eaeb35"), null, null, null, "41.jpg", new Guid("05e3d510-6866-47b9-ad75-3cf2fd330c9c"), 1, null, null, null },
                    { new Guid("a04b281b-352c-4917-8542-678e2f6b5275"), null, null, null, "42.jpg", new Guid("05e3d510-6866-47b9-ad75-3cf2fd330c9c"), 1, null, null, null },
                    { new Guid("6c3eac66-be47-4999-9c5a-57f8cd9770f9"), null, null, null, "43.jpg", new Guid("05e3d510-6866-47b9-ad75-3cf2fd330c9c"), 1, null, null, null },
                    { new Guid("43e628e7-f6ed-4bf3-8e76-d4c85e0859ce"), null, null, null, "44.jpg", new Guid("67614fef-8f67-4ba5-af0d-f35479d003f2"), 1, null, null, null },
                    { new Guid("6d155e21-e07d-4d85-8d2b-0b85bd2aac0d"), null, null, null, "45.jpg", new Guid("67614fef-8f67-4ba5-af0d-f35479d003f2"), 1, null, null, null },
                    { new Guid("65fe9587-8e79-43ca-b8e8-71520012c0f6"), null, null, null, "32.jpg", new Guid("ebf25e2d-15e5-4133-ad82-156f83f4ce96"), 1, null, null, null },
                    { new Guid("b2a9c4f9-f48e-422d-a0cb-72853b286f53"), null, null, null, "17.jpg", new Guid("44926cd7-1678-4808-a2b0-df95c6f865fc"), 1, null, null, null },
                    { new Guid("5cb9d753-87ba-4a8b-af44-0c6628c5a5eb"), null, null, null, "7.jpg", new Guid("2322717a-d36d-4299-af9f-2b6faedd1423"), 1, null, null, null },
                    { new Guid("de3a5f9f-0d60-4e46-9190-80a176157f47"), null, null, null, "15.jpg", new Guid("44926cd7-1678-4808-a2b0-df95c6f865fc"), 1, null, null, null },
                    { new Guid("caf21ce9-00f6-4680-bab7-0de1ea7e22c6"), null, null, null, "16.jpg", new Guid("44926cd7-1678-4808-a2b0-df95c6f865fc"), 1, null, null, null },
                    { new Guid("94381c09-4b6e-40e9-9b64-ed5cbbe2b355"), null, null, null, "2.jpg", new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null },
                    { new Guid("2e170003-56cd-4238-b726-28b9da187c6f"), null, null, null, "3.jpg", new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null },
                    { new Guid("e3e58007-a067-4a17-91e0-77538f7a5f46"), null, null, null, "4.jpg", new Guid("c15eb71a-0120-434c-bbad-8011d796b392"), 1, null, null, null },
                    { new Guid("1f315276-33c2-4b16-a2bc-c3678ee36d3e"), null, null, null, "5.jpg", new Guid("c15eb71a-0120-434c-bbad-8011d796b392"), 1, null, null, null },
                    { new Guid("79c42bc7-996a-47c3-aa2c-d990bf033c47"), null, null, null, "6.jpg", new Guid("c15eb71a-0120-434c-bbad-8011d796b392"), 1, null, null, null },
                    { new Guid("6ace962f-0339-4a72-b708-347176a5f849"), null, null, null, "46.jpg", new Guid("67614fef-8f67-4ba5-af0d-f35479d003f2"), 1, null, null, null },
                    { new Guid("2ca39aa2-05e6-4c7a-a63d-7d049f9c64cc"), null, null, null, "1.jpg", new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null },
                    { new Guid("a779c6f3-6894-4a88-a2b5-9cfedd9a184a"), null, null, null, "9.jpg", new Guid("2322717a-d36d-4299-af9f-2b6faedd1423"), 1, null, null, null },
                    { new Guid("d561a26b-07cc-4174-bffb-927f51217c5e"), null, null, null, "10.jpg", new Guid("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"), 1, null, null, null },
                    { new Guid("07a87c76-dbad-414e-b83f-b97473bedf3d"), null, null, null, "11.jpg", new Guid("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"), 1, null, null, null },
                    { new Guid("4653ceed-90d4-4ee4-a28a-afee5e4af903"), null, null, null, "12.jpg", new Guid("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"), 1, null, null, null },
                    { new Guid("36039833-7266-4979-bbef-3f1fb3901e32"), null, null, null, "13.jpg", new Guid("b9b5381c-de81-4953-a7ee-9a782b9652da"), 1, null, null, null },
                    { new Guid("9bafe1bd-787a-423b-b729-f621423196c4"), null, null, null, "14.jpg", new Guid("b9b5381c-de81-4953-a7ee-9a782b9652da"), 1, null, null, null },
                    { new Guid("83af45a5-3077-48a4-9a38-053923f7fb97"), null, null, null, "8.jpg", new Guid("2322717a-d36d-4299-af9f-2b6faedd1423"), 1, null, null, null }
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
