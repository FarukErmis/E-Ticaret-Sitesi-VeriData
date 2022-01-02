using CommercialSite.Core.Entity.Enums;
using CommercialSite.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Model.SeedData
{
    public class ProductCommentSeedData : IEntityTypeConfiguration<ProductComment>
    {
        public void Configure(EntityTypeBuilder<ProductComment> builder)
        {
            builder.HasData(
               new ProductComment
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("2322717a-d36d-4299-af9f-2b6faedd1423"),
                   Comment = "cihaz harika ancak 2080 max-q olması desktop versiyonda 2070'e denk geldiği nutulmamalı.Oyunlarda overclocklu hali ile gayet tatmin edici fps'ler sunuyor.tavsiye olunur.",
                   CreatedUserId = Guid.Parse("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"),
                   Rate = "5",
                   CreatedDate = DateTime.Now,
                   Status = Status.Active,
                   ThumbsUp = 6,
                   ThumbDown = 4
               });
            builder.HasData(
               new ProductComment
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("2322717a-d36d-4299-af9f-2b6faedd1423"),
                   Comment = "Öncelikle hızlı kargo gönderimi için Hepsi Buradaya teşekkür ederim. Ürün elime hasarsız bir ekilde ulaştı. Kutulama oldukça başarılı. Ürün gerçekten çok kaliteli. Hem iş hem de oyun amaçlı olarak ullanılabiliyor. Performans olarak Harika bir ürün herkese gönül rahatlığıyla tavsiye ederim.",
                   CreatedUserId = Guid.Parse("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"),
                   Rate = "5",
                   Status = Status.Active,
                   CreatedDate = DateTime.Now,
                   ThumbsUp = 6,
                   ThumbDown = 4
               });
            builder.HasData(
               new ProductComment
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("49669332-44e1-4696-84c0-9ab229061315"),
                   Comment = "Ürün gayet başarılı, 512 gb ssdli modeli yerine tercih ettim, kurulum sıkıntı oldu, riverleri mutlaka lenovonun kendi sitesinden indirmenizi tavsiye ederim, satıcı güzel, iletişimi iyiydi.",
                   CreatedUserId = Guid.Parse("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"),
                   Rate = "5",
                   Status = Status.Active,
                   CreatedDate = DateTime.Now,
                   ThumbsUp = 6,
                   ThumbDown = 4
               });
            builder.HasData(
               new ProductComment
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("a7630777-3514-46e6-8f46-ff84d48a32a8"),
                   Comment = "Ürün fotoğraflardaki gibi 3 4 saattir kurulum için kullanıyorum gayet hızlı.İstanbul içinde seniz kargo süreci çok hızlı bir şekilde işliyor. Free dos olduğu için format attıktan sonra ilk iş windowsu son sürümegüncelleyin daha sonra kurulum yapın.Lenovo sitesindeki sürücülerin bazıları windows son sürüm olmadığı için kurulmuyorözellikle ekran kartları. Klavye hissiyatı çok iyi. Satıcı ilgili aradığımda direkt çözüm odaklı konuştular. Gerekli azılımları indirmenizi tavsiye ederim. Düşünmeden alabilirsiniz",
                   CreatedUserId = Guid.Parse("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"),
                   Rate = "5",
                   Status = Status.Active,
                   CreatedDate = DateTime.Now,
                   ThumbsUp = 6,
                   ThumbDown = 4
               });
            builder.HasData(
               new ProductComment
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"),
                   Comment = "Ürün iyi hoş güzel de aga bu nasıl bir dolar kuru, adam bunu 400 500 lira sayıp alıyor biz iye 2 asgari ücretten fazla koyuyoz Allah aşkına ya.  Not: Almanya bizi kıskanıyor :'(",
                   CreatedUserId = Guid.Parse("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"),
                   Rate = "5",
                   Status = Status.Active,
                   CreatedDate = DateTime.Now,
                   ThumbsUp = 6,
                   ThumbDown = 4
               });
            builder.HasData(
               new ProductComment
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("ebf25e2d-15e5-4133-ad82-156f83f4ce96"),
                   Comment = "Öncelikle Ürünü alış sebebim laptopu internette bişeyler bakmak, alışveriş yapmak sosyal edyada takılmak için kullanırken ağır olması şarjının çok gitmemesiydi. Ben öyle oyun oynayan biri değilim o yüzden yun performansı açısından bir değerlendirme yapamayacağım. Ürün beklediğim gibi. Bilgisayardan google chrome'a nasıl idiyorsanız bu cihazla da aynen girebiliyorsunuz. Şarj konusuna gelirsek net 6 saat ekran açık İnternette ezinebiliyorsunuz. Cihazın hoparlörlerinden gelen ses çok başarılı ancak kulaklık konusunda çok iddialı değil. Aşağıda orumda arkadaş usb bellekleri görmüyor demiş ben çatır çutur takıyorum gayette görüyor. Cihazın iki kusuru var bence irincisi yeni olduğundan dolayı kılıf olsun ekran koruyucu olsun bu tarz aksesuarlar açısından sıkıntısı var. İkincisi e batarya biraz daha büyük olabilirdi. Ancak şunu da söyleyeyim bu aralar işe gitmiyor oluşum ve cihazın yeni oluşundanötürü sürekli elimde olması da pilini yeterli bulmamamda etkili bir faktördür. Sonuç olarak benim aldığım amaçla lacaklara tavsiye ederim.Kargo gayet hızlı sitenin tahmini olarak size söylediği tarihten 2 gün önce elinize laşıyor.",
                   CreatedUserId = Guid.Parse("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"),
                   Rate = "5",
                   Status = Status.Active,
                   CreatedDate = DateTime.Now,
                   ThumbsUp = 6,
                   ThumbDown = 4
               });
            builder.HasData(
               new ProductComment
               {
                   Id = Guid.NewGuid(),
                   ProductId = Guid.Parse("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"),
                   Comment = "Televizyonun Artıları: + iPhone ile tam uyumlu olması + Hızlı açılış süresi + Menülerdeki kıcılık + Fiyat performans ürünü Eksileri - Kanal geçişleri bazen can sıkabiliyor - Menünün bazı kısımları yavaş alışıyor - Görüntü ayarlarında istenen rengi yakalamak olması gerekenden zor. Genel olarak ben üründen memnunum.Daha yi olabilirdi ancak o zamanda tabiki fiyatı daha da yüksek olacaktı.Ayrıca satın aldığım satıcının paketlemesi oldukça yi.Sadece kutusu ile göndermeyip dışına birde kabarcıklı poşet sarması teslimat sırasında kontrol etmenizi çok çok olaylaştırıyor.Satıcının ilgiside gayet iyiydi.Çok teşekkürler.",
                   CreatedUserId = Guid.Parse("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"),
                   Rate = "5",
                   Status = Status.Active,
                   CreatedDate = DateTime.Now,
                   ThumbsUp = 6,
                   ThumbDown = 4
               });
        }
    }
}
