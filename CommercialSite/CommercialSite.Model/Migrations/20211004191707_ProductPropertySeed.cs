using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommercialSite.Model.Migrations
{
    public partial class ProductPropertySeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductProperties",
                columns: new[] { "Id", "CreatedDate", "CreatedIp", "CreatedUserId", "ProductId", "Status", "UpdatedDate", "UpdatedIp", "UpdatedUserId", "VarKey", "VarValue" },
                values: new object[,]
                {
                    { new Guid("c2148545-3e8b-4ba8-a41b-bcd1cb3acaca"), null, null, null, new Guid("ebf25e2d-15e5-4133-ad82-156f83f4ce96"), 1, null, null, null, "Dahili Hafıza", "64 GB" },
                    { new Guid("e7ce7044-335f-4e9e-b41a-eb61a16ea070"), null, null, null, new Guid("49669332-44e1-4696-84c0-9ab229061315"), 1, null, null, null, "Dahili Hafıza", "128 GB" },
                    { new Guid("d3374918-ae57-4d2b-9862-0c72e8c476a7"), null, null, null, new Guid("ebf25e2d-15e5-4133-ad82-156f83f4ce96"), 1, null, null, null, "Kamera Çözünürlüğü", "13 MP" },
                    { new Guid("2916c35b-96c1-44f8-a019-7a0db8ce79a9"), null, null, null, new Guid("ebf25e2d-15e5-4133-ad82-156f83f4ce96"), 1, null, null, null, "Ön (Selfie) Kamera", "8,0 MP" },
                    { new Guid("d38c3e48-224c-464f-a855-66a1b1b36e62"), null, null, null, new Guid("ebf25e2d-15e5-4133-ad82-156f83f4ce96"), 1, null, null, null, "Ekran Boyutu", "6,47 inç" },
                    { new Guid("c9953e9e-f21f-4808-9cf2-f9a325115fce"), null, null, null, new Guid("ebf25e2d-15e5-4133-ad82-156f83f4ce96"), 1, null, null, null, "Pil Gücü", "4680 mAh" },
                    { new Guid("5271f753-a6c4-4bbd-959f-e3042be934e6"), null, null, null, new Guid("ebf25e2d-15e5-4133-ad82-156f83f4ce96"), 1, null, null, null, "RAM Kapasitesi", "4 GB" },
                    { new Guid("6e605277-2a70-4065-848b-94bb78b7d198"), null, null, null, new Guid("a4518427-e6f0-46bd-bbbd-4dcdaa92966e"), 1, null, null, null, "Çözünürlük", "4K Ultra HD" },
                    { new Guid("344602f3-dcac-49c0-bc6e-523db343d05e"), null, null, null, new Guid("b9b5381c-de81-4953-a7ee-9a782b9652da"), 1, null, null, null, "Ram Kapasitesi", "4 GB" },
                    { new Guid("dfd7051c-2ae5-475e-88cd-eb8ad920600d"), null, null, null, new Guid("a4518427-e6f0-46bd-bbbd-4dcdaa92966e"), 0, null, null, null, "Smart TV", "Var" },
                    { new Guid("4e1e9808-6dec-4afa-a462-71437553e4dc"), null, null, null, new Guid("a4518427-e6f0-46bd-bbbd-4dcdaa92966e"), 1, null, null, null, "Ekran Ebatı", "50 inç / 127 cm" },
                    { new Guid("a8889737-8177-4ec7-8751-f1b8bcefc193"), null, null, null, new Guid("44926cd7-1678-4808-a2b0-df95c6f865fc"), 1, null, null, null, "Wi-Fi", "Var" },
                    { new Guid("897e0375-74b9-4187-970e-9ae7ac24cfa1"), null, null, null, new Guid("44926cd7-1678-4808-a2b0-df95c6f865fc"), 1, null, null, null, "Smart TV", "Var" },
                    { new Guid("d6010c72-0682-4708-aaf2-e114f72bcf04"), null, null, null, new Guid("44926cd7-1678-4808-a2b0-df95c6f865fc"), 1, null, null, null, "Ekran Ebatı", "43 inç / 108 cm" },
                    { new Guid("c45fb327-385c-4323-8be2-7181fdd9921c"), null, null, null, new Guid("49669332-44e1-4696-84c0-9ab229061315"), 1, null, null, null, "RAM Kapasitesi", "8 GB" },
                    { new Guid("d44b5315-dbb8-4005-990e-6ff89b5ee904"), null, null, null, new Guid("b9b5381c-de81-4953-a7ee-9a782b9652da"), 1, null, null, null, "Max Ekran Çözünürlüğü", "1920 x 1200" },
                    { new Guid("92235e57-e23e-4e72-b82e-e6a4f5135fbf"), null, null, null, new Guid("b9b5381c-de81-4953-a7ee-9a782b9652da"), 1, null, null, null, "Dahili Hafıza", "64 GB" },
                    { new Guid("95e28200-0681-47cb-aefb-0d658227d6cc"), null, null, null, new Guid("a4518427-e6f0-46bd-bbbd-4dcdaa92966e"), 1, null, null, null, "Görüntü Teknolojisi", "LED" },
                    { new Guid("d4641f47-0297-4a03-a7af-f541bfa3ca7f"), null, null, null, new Guid("49669332-44e1-4696-84c0-9ab229061315"), 1, null, null, null, "Pil Gücü", "4310 mAh" },
                    { new Guid("1db30347-ad02-45ee-953b-43e708e3d90a"), null, null, null, new Guid("67614fef-8f67-4ba5-af0d-f35479d003f2"), 1, null, null, null, "Ön (Selfie) Kamera", "16 MP" },
                    { new Guid("7dfba84d-1527-4f58-8137-ac374197a355"), null, null, null, new Guid("49669332-44e1-4696-84c0-9ab229061315"), 1, null, null, null, "Ön (Selfie) Kamera", "32 MP" },
                    { new Guid("6707b9d6-eac9-4dc6-a5f9-76ffd24f9b7a"), null, null, null, new Guid("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"), 1, null, null, null, "Dahili Hafıza", "256 GB" },
                    { new Guid("cf4ed36c-39a5-4710-a96b-557939a6b74a"), null, null, null, new Guid("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"), 1, null, null, null, "Pil Gücü", "3174 mAh" },
                    { new Guid("94f9e1ab-19eb-44be-b545-054c239f23ee"), null, null, null, new Guid("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"), 1, null, null, null, "Ekran Boyutu", "6,5 inç" },
                    { new Guid("3bddf1ee-8c55-4fea-9706-3d05ac46af10"), null, null, null, new Guid("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"), 1, null, null, null, "Kamera Çözünürlüğü", "12 MP + 12 MP" },
                    { new Guid("4e3c3fcb-5690-43e8-9372-40a9a2ce40e0"), null, null, null, new Guid("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"), 1, null, null, null, "Ön (Selfie) Kamera", "7,0 MP" },
                    { new Guid("7cf79e6d-8a06-46d6-b4be-13b44e74c2a6"), null, null, null, new Guid("e55ae9f3-888d-4c69-a0e7-4403a8292d95"), 1, null, null, null, "Dahili Hafıza", "256 GB" },
                    { new Guid("0553da36-44ef-4aca-a7a4-3de86f16d184"), null, null, null, new Guid("e55ae9f3-888d-4c69-a0e7-4403a8292d95"), 1, null, null, null, "Ekran Boyutu", "6,9 inç" },
                    { new Guid("a12fc4db-6de4-4e2d-8893-4331da061144"), null, null, null, new Guid("49669332-44e1-4696-84c0-9ab229061315"), 1, null, null, null, "Ekran Boyutu", "6,4 inç" },
                    { new Guid("01bc3e73-7711-4629-9b8e-38656abaa1ae"), null, null, null, new Guid("e55ae9f3-888d-4c69-a0e7-4403a8292d95"), 1, null, null, null, "RAM Kapasitesi", "8 GB" },
                    { new Guid("ee6f0eeb-27a1-47c5-af5f-fb0f69be9bad"), null, null, null, new Guid("e55ae9f3-888d-4c69-a0e7-4403a8292d95"), 1, null, null, null, "Pil Gücü", "4500 mAh" },
                    { new Guid("38271fb5-6217-4f3d-8a58-8d5e844bed4f"), null, null, null, new Guid("e55ae9f3-888d-4c69-a0e7-4403a8292d95"), 1, null, null, null, "Ön (Selfie) Kamera", "10 MP" },
                    { new Guid("4f3d8bd6-1c89-4fff-a29f-c4224be59b58"), null, null, null, new Guid("67614fef-8f67-4ba5-af0d-f35479d003f2"), 1, null, null, null, "Kamera Çözünürlüğü", "108 MP + 8 MP + 5 MP + 2 MP" },
                    { new Guid("f606fdc0-62d7-4d64-a8c8-6ba578b970ad"), null, null, null, new Guid("b9b5381c-de81-4953-a7ee-9a782b9652da"), 1, null, null, null, "Ekran Boyutu", "10,3 inç" },
                    { new Guid("f2f5ddcc-7e68-4738-946f-8b999e39a5c7"), null, null, null, new Guid("67614fef-8f67-4ba5-af0d-f35479d003f2"), 1, null, null, null, "Pil Gücü", "5020 mAh" },
                    { new Guid("4eb55354-0905-47ea-b24d-360f17fdc09c"), null, null, null, new Guid("67614fef-8f67-4ba5-af0d-f35479d003f2"), 1, null, null, null, "RAM Kapasitesi", "8 GB" },
                    { new Guid("8dd100e2-7aa2-418f-a09c-8f07cdf82062"), null, null, null, new Guid("67614fef-8f67-4ba5-af0d-f35479d003f2"), 1, null, null, null, "Dahili Hafıza", "128 GB" },
                    { new Guid("b8ccbd7b-417b-47e5-8957-e6b763438235"), null, null, null, new Guid("49669332-44e1-4696-84c0-9ab229061315"), 1, null, null, null, "Kamera Çözünürlüğü", "48 MP + 8 MP + 2 MP + 2 MP" },
                    { new Guid("2350da08-01e5-47a7-9b8d-50bf4d6b3d35"), null, null, null, new Guid("e55ae9f3-888d-4c69-a0e7-4403a8292d95"), 1, null, null, null, "Kamera Çözünürlüğü", "108 MP + 12 MP + 12 MP" },
                    { new Guid("676418b7-3350-4b90-9695-3317c5d76ed1"), null, null, null, new Guid("b9b5381c-de81-4953-a7ee-9a782b9652da"), 1, null, null, null, "Kamera", "Çift Kamera" },
                    { new Guid("3fc438d8-7b2e-4eca-be23-2d7ad9b0a000"), null, null, null, new Guid("2322717a-d36d-4299-af9f-2b6faedd1423"), 1, null, null, null, "İşletim Sistemi", "Yok (Free Dos)" },
                    { new Guid("a8c105e3-f5f9-4160-92d6-65114ed5963c"), null, null, null, new Guid("05e3d510-6866-47b9-ad75-3cf2fd330c9c"), 1, null, null, null, "Dahili Hafıza", "128 GB" },
                    { new Guid("beb1492f-a8a6-4c2e-9059-d67613897598"), null, null, null, new Guid("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"), 1, null, null, null, "RAM Kapasitesi", "4 GB" },
                    { new Guid("8f8dd5e0-b846-4cae-b829-193e7b505bc2"), null, null, null, new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null, "Harddisk Kapasitesi", "512 GB SSD" },
                    { new Guid("7a655f86-01ce-4138-9513-041760fbc609"), null, null, null, new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null, "Cihaz Ağırlığı", "1 - 2 kg" },
                    { new Guid("ceb82715-7c72-4d1d-9da0-cfb4047e5af5"), null, null, null, new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null, "Dokunmatik Ekran", "Yok" },
                    { new Guid("ef1ef8ee-f002-4265-abbe-5856c5009895"), null, null, null, new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null, "Ekran Özelliği", "IPS" },
                    { new Guid("6d7eda95-5ff5-48cd-80b0-9f2f8c1c5a9b"), null, null, null, new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null, "Bellek Hızı", "2933 MHz" },
                    { new Guid("044ad007-df38-47cd-a7ae-13dcccee56a5"), null, null, null, new Guid("05e3d510-6866-47b9-ad75-3cf2fd330c9c"), 1, null, null, null, "Max Ekran Çözünürlüğü", "2560 x 1600" },
                    { new Guid("24129478-d71f-42bd-b5d0-604aee25e963"), null, null, null, new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null, "Max Ekran Çözünürlüğü", "1920 x 1080" },
                    { new Guid("5abafbb0-4213-4ad5-bf0b-211c2943a3c0"), null, null, null, new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null, "Şarjlı Kullanım Süresi", "4 - 6 Saat" },
                    { new Guid("1082b494-3bce-41a8-b23a-49ee2f2890d2"), null, null, null, new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null, "Temel İşlemci Hızı", "2,60 GHz" },
                    { new Guid("a0703847-8d1b-4665-93e7-efc4422384c5"), null, null, null, new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null, "Klavye", "Q Türkçe" },
                    { new Guid("d8dec40b-3b47-45be-8f4a-73d04d864479"), null, null, null, new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null, "Usb 2.0", "Yok" },
                    { new Guid("988577da-dee4-4140-b27b-9bb84bf90510"), null, null, null, new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null, "USB 3.0", "Yok" },
                    { new Guid("5533927a-c9a4-42c9-96ac-4ca9b3c00151"), null, null, null, new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null, "Bellek Yuvası", "2" },
                    { new Guid("4078b6cf-aee8-442e-8488-7ea3d6ae018b"), null, null, null, new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null, "Garanti Süresi (Ay)", "24" },
                    { new Guid("4e7046c7-ec34-4be2-8dfa-20b7f1da4505"), null, null, null, new Guid("05e3d510-6866-47b9-ad75-3cf2fd330c9c"), 1, null, null, null, "Ekran Boyutu", "11 inç" },
                    { new Guid("bdde7fa2-8373-4ae6-9c1b-bebc0edb1679"), null, null, null, new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), 1, null, null, null, "USB 3.1", "3" },
                    { new Guid("eee4d28c-3cd7-408d-87bf-e4b352cff156"), null, null, null, new Guid("05e3d510-6866-47b9-ad75-3cf2fd330c9c"), 1, null, null, null, "Kamera", "Çift Kamera" },
                    { new Guid("4ab7269b-e924-4b2e-9f3b-62fdd5f6a991"), null, null, null, new Guid("2322717a-d36d-4299-af9f-2b6faedd1423"), 1, null, null, null, "Ram", "16 GB" },
                    { new Guid("536ae186-943d-4a55-a909-250cd9032b7c"), null, null, null, new Guid("2322717a-d36d-4299-af9f-2b6faedd1423"), 1, null, null, null, "Ekran Kartı", "GTX 1650" },
                    { new Guid("09962ad9-907f-429c-8d8c-1b622bc3681c"), null, null, null, new Guid("2322717a-d36d-4299-af9f-2b6faedd1423"), 1, null, null, null, "Harddisk Kapasitesi", "512 GB SSD" },
                    { new Guid("187d5e59-4ea4-403e-bfa8-913f9a1f240e"), null, null, null, new Guid("c15eb71a-0120-434c-bbad-8011d796b392"), 1, null, null, null, "Harddisk Kapasitesi", "1TB SSD" },
                    { new Guid("3e651d72-034c-4919-9bb6-4fabbd9154bf"), null, null, null, new Guid("c15eb71a-0120-434c-bbad-8011d796b392"), 1, null, null, null, "Ram", "8 GB" },
                    { new Guid("8a8bc970-8fda-4056-a1e4-9f40ba98c6de"), null, null, null, new Guid("c15eb71a-0120-434c-bbad-8011d796b392"), 1, null, null, null, "İşletim Sistemi", "Yok (Free Dos)" },
                    { new Guid("01ac3b21-b99c-41bc-a936-16909ee4225f"), null, null, null, new Guid("c15eb71a-0120-434c-bbad-8011d796b392"), 1, null, null, null, "Ekran Kartı", "Nvidia GeForce RTX 2080 Super" },
                    { new Guid("db209cfa-6306-4cbd-929f-5110766546ae"), null, null, null, new Guid("c15eb71a-0120-434c-bbad-8011d796b392"), 1, null, null, null, "Ekran Boyutu", "15,6 inç" },
                    { new Guid("cecdc30d-8549-4dc6-8bcd-7ee5b561fbf3"), null, null, null, new Guid("2322717a-d36d-4299-af9f-2b6faedd1423"), 1, null, null, null, "Ekran Boyutu", "15,6 inç" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
