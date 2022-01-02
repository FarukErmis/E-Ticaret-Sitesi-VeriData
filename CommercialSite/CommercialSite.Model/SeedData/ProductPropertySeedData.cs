using CommercialSite.Core.Entity.Enums;
using CommercialSite.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.SeedData
{
    public class ProductPropertySeedData : IEntityTypeConfiguration<ProductProperty>
    {
        public void Configure(EntityTypeBuilder<ProductProperty> builder)
        {
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   VarKey = "Harddisk Kapasitesi",
                   VarValue = "512 GB SSD"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   VarKey = "Cihaz Ağırlığı",
                   VarValue = "1 - 2 kg"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   VarKey = "Dokunmatik Ekran",
                   VarValue = "Yok"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   VarKey = "Ekran Özelliği",
                   VarValue = "IPS"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   VarKey = "Bellek Hızı",
                   VarValue = "2933 MHz"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   VarKey = "Bellek Yuvası",
                   VarValue = "2"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   VarKey = "Max Ekran Çözünürlüğü",
                   VarValue = "1920 x 1080"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   VarKey = "Şarjlı Kullanım Süresi",
                   VarValue = "4 - 6 Saat"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   VarKey = "Temel İşlemci Hızı",
                   VarValue = "2,60 GHz"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   VarKey = "Klavye",
                   VarValue = "Q Türkçe"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   VarKey = "Usb 2.0",
                   VarValue = "Yok"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   VarKey = "USB 3.0",
                   VarValue = "Yok"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   VarKey = "USB 3.1",
                   VarValue = "3"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Status = Status.Active,
                   VarKey = "Garanti Süresi (Ay)",
                   VarValue = "24"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("c15eb71a-0120-434c-bbad-8011d796b392"),
                   Status = Status.Active,
                   VarKey = "Ekran Boyutu",
                   VarValue = "15,6 inç"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("c15eb71a-0120-434c-bbad-8011d796b392"),
                   Status = Status.Active,
                   VarKey = "Ekran Kartı",
                   VarValue = "Nvidia GeForce RTX 2080 Super"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("c15eb71a-0120-434c-bbad-8011d796b392"),
                   Status = Status.Active,
                   VarKey = "İşletim Sistemi",
                   VarValue = "Yok (Free Dos)"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("c15eb71a-0120-434c-bbad-8011d796b392"),
                   Status = Status.Active,
                   VarKey = "Ram",
                   VarValue = "8 GB"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("c15eb71a-0120-434c-bbad-8011d796b392"),
                   Status = Status.Active,
                   VarKey = "Harddisk Kapasitesi",
                   VarValue = "1TB SSD"
               });
            builder.HasData(
               new ProductProperty
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("2322717a-d36d-4299-af9f-2b6faedd1423"),
                   Status = Status.Active,
                   VarKey = "Ekran Boyutu",
                   VarValue = "15,6 inç"
               });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("2322717a-d36d-4299-af9f-2b6faedd1423"),
                  Status = Status.Active,
                  VarKey = "Ekran Kartı",
                  VarValue = "GTX 1650"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("2322717a-d36d-4299-af9f-2b6faedd1423"),
                  Status = Status.Active,
                  VarKey = "İşletim Sistemi",
                  VarValue = "Yok (Free Dos)"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("2322717a-d36d-4299-af9f-2b6faedd1423"),
                  Status = Status.Active,
                  VarKey = "Ram",
                  VarValue = "16 GB"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("2322717a-d36d-4299-af9f-2b6faedd1423"),
                  Status = Status.Active,
                  VarKey = "Harddisk Kapasitesi",
                  VarValue = "512 GB SSD"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("05e3d510-6866-47b9-ad75-3cf2fd330c9c"),
                  Status = Status.Active,
                  VarKey = "",
                  VarValue = ""
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("05e3d510-6866-47b9-ad75-3cf2fd330c9c"),
                  Status = Status.Active,
                  VarKey = "Kamera",
                  VarValue = "Çift Kamera"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("05e3d510-6866-47b9-ad75-3cf2fd330c9c"),
                  Status = Status.Active,
                  VarKey = "Ekran Boyutu",
                  VarValue = "11 inç"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("05e3d510-6866-47b9-ad75-3cf2fd330c9c"),
                  Status = Status.Active,
                  VarKey = "Dahili Hafıza",
                  VarValue = "128 GB"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("05e3d510-6866-47b9-ad75-3cf2fd330c9c"),
                  Status = Status.Active,
                  VarKey = "Max Ekran Çözünürlüğü",
                  VarValue = "2560 x 1600"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("b9b5381c-de81-4953-a7ee-9a782b9652da"),
                  Status = Status.Active,
                  VarKey = "Kamera",
                  VarValue = "Çift Kamera"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("b9b5381c-de81-4953-a7ee-9a782b9652da"),
                  Status = Status.Active,
                  VarKey = "Ekran Boyutu",
                  VarValue = "10,3 inç"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("b9b5381c-de81-4953-a7ee-9a782b9652da"),
                  Status = Status.Active,
                  VarKey = "Dahili Hafıza",
                  VarValue = "64 GB"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("b9b5381c-de81-4953-a7ee-9a782b9652da"),
                  Status = Status.Active,
                  VarKey = "Max Ekran Çözünürlüğü",
                  VarValue = "1920 x 1200"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("b9b5381c-de81-4953-a7ee-9a782b9652da"),
                  Status = Status.Active,
                  VarKey = "Ram Kapasitesi",
                  VarValue = "4 GB"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("44926cd7-1678-4808-a2b0-df95c6f865fc"),
                  Status = Status.Active,
                  VarKey = "Ekran Ebatı",
                  VarValue = "43 inç / 108 cm"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("44926cd7-1678-4808-a2b0-df95c6f865fc"),
                  Status = Status.Active,
                  VarKey = "Smart TV",
                  VarValue = "Var"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("44926cd7-1678-4808-a2b0-df95c6f865fc"),
                  Status = Status.Active,
                  VarKey = "Wi-Fi",
                  VarValue = "Var"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("a4518427-e6f0-46bd-bbbd-4dcdaa92966e"),
                  Status = Status.Active,
                  VarKey = "Ekran Ebatı",
                  VarValue = "50 inç / 127 cm"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("a4518427-e6f0-46bd-bbbd-4dcdaa92966e"),
                  Status = Status.Active,
                  VarKey = "Smart TV",
                  VarValue = "Var"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("a4518427-e6f0-46bd-bbbd-4dcdaa92966e"),
                  Status = Status.Active,
                  VarKey = "Görüntü Teknolojisi",
                  VarValue = "LED"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("a4518427-e6f0-46bd-bbbd-4dcdaa92966e"),
                  Status = Status.Active,
                  VarKey = "Çözünürlük",
                  VarValue = "4K Ultra HD"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("ebf25e2d-15e5-4133-ad82-156f83f4ce96"),
                  Status = Status.Active,
                  VarKey = "Dahili Hafıza",
                  VarValue = "64 GB"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("ebf25e2d-15e5-4133-ad82-156f83f4ce96"),
                  Status = Status.Active,
                  VarKey = "RAM Kapasitesi",
                  VarValue = "4 GB"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("ebf25e2d-15e5-4133-ad82-156f83f4ce96"),
                  Status = Status.Active,
                  VarKey = "Pil Gücü",
                  VarValue = "4680 mAh"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("ebf25e2d-15e5-4133-ad82-156f83f4ce96"),
                  Status = Status.Active,
                  VarKey = "Ekran Boyutu",
                  VarValue = "6,47 inç"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("ebf25e2d-15e5-4133-ad82-156f83f4ce96"),
                  Status = Status.Active,
                  VarKey = "Ön (Selfie) Kamera",
                  VarValue = "8,0 MP"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("ebf25e2d-15e5-4133-ad82-156f83f4ce96"),
                  Status = Status.Active,
                  VarKey = "Kamera Çözünürlüğü",
                  VarValue = "13 MP"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("49669332-44e1-4696-84c0-9ab229061315"),
                  Status = Status.Active,
                  VarKey = "Dahili Hafıza",
                  VarValue = "128 GB"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("49669332-44e1-4696-84c0-9ab229061315"),
                  Status = Status.Active,
                  VarKey = "RAM Kapasitesi",
                  VarValue = "8 GB"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("49669332-44e1-4696-84c0-9ab229061315"),
                  Status = Status.Active,
                  VarKey = "Pil Gücü",
                  VarValue = "4310 mAh"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("49669332-44e1-4696-84c0-9ab229061315"),
                  Status = Status.Active,
                  VarKey = "Ekran Boyutu",
                  VarValue = "6,4 inç"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("49669332-44e1-4696-84c0-9ab229061315"),
                  Status = Status.Active,
                  VarKey = "Ön (Selfie) Kamera",
                  VarValue = "32 MP"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("49669332-44e1-4696-84c0-9ab229061315"),
                  Status = Status.Active,
                  VarKey = "Kamera Çözünürlüğü",
                  VarValue = "48 MP + 8 MP + 2 MP + 2 MP"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("67614fef-8f67-4ba5-af0d-f35479d003f2"),
                  Status = Status.Active,
                  VarKey = "Dahili Hafıza",
                  VarValue = "128 GB"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("67614fef-8f67-4ba5-af0d-f35479d003f2"),
                  Status = Status.Active,
                  VarKey = "RAM Kapasitesi",
                  VarValue = "8 GB"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("67614fef-8f67-4ba5-af0d-f35479d003f2"),
                  Status = Status.Active,
                  VarKey = "Pil Gücü",
                  VarValue = "5020 mAh"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("67614fef-8f67-4ba5-af0d-f35479d003f2"),
                  Status = Status.Active,
                  VarKey = "Ön (Selfie) Kamera",
                  VarValue = "16 MP"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("67614fef-8f67-4ba5-af0d-f35479d003f2"),
                  Status = Status.Active,
                  VarKey = "Kamera Çözünürlüğü",
                  VarValue = "108 MP + 8 MP + 5 MP + 2 MP"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("e55ae9f3-888d-4c69-a0e7-4403a8292d95"),
                  Status = Status.Active,
                  VarKey = "Ön (Selfie) Kamera",
                  VarValue = "10 MP"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("e55ae9f3-888d-4c69-a0e7-4403a8292d95"),
                  Status = Status.Active,
                  VarKey = "Pil Gücü",
                  VarValue = "4500 mAh"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  Status = Status.Active,
                  ProductId = Guid.Parse("e55ae9f3-888d-4c69-a0e7-4403a8292d95"),
                  VarKey = "Kamera Çözünürlüğü",
                  VarValue = "108 MP + 12 MP + 12 MP"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("e55ae9f3-888d-4c69-a0e7-4403a8292d95"),
                  Status = Status.Active,
                  VarKey = "RAM Kapasitesi",
                  VarValue = "8 GB"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("e55ae9f3-888d-4c69-a0e7-4403a8292d95"),
                  Status = Status.Active,
                  VarKey = "Ekran Boyutu",
                  VarValue = "6,9 inç"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("e55ae9f3-888d-4c69-a0e7-4403a8292d95"),
                  Status = Status.Active,
                  VarKey = "Dahili Hafıza",
                  VarValue = "256 GB"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"),
                  Status = Status.Active,
                  VarKey = "Ön (Selfie) Kamera",
                  VarValue = "7,0 MP"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"),
                  Status = Status.Active,
                  VarKey = "Kamera Çözünürlüğü",
                  VarValue = "12 MP + 12 MP"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"),
                  Status = Status.Active,
                  VarKey = "Ekran Boyutu",
                  VarValue = "6,5 inç"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"),
                  Status = Status.Active,
                  VarKey = "Pil Gücü",
                  VarValue = "3174 mAh"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"),
                  Status = Status.Active,
                  VarKey = "",
                  VarValue = ""
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"),
                  Status = Status.Active,
                  VarKey = "Dahili Hafıza",
                  VarValue = "256 GB"
              });
            builder.HasData(
              new ProductProperty
              {
                  Id = Guid.NewGuid(),
                  ProductId = Guid.Parse("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"),
                  Status = Status.Active,
                  VarKey = "RAM Kapasitesi",
                  VarValue = "4 GB"
              });
            
        }
    }
}
