using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommercialSite.Model.Migrations
{
    public partial class ProductCommentSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductComments",
                columns: new[] { "Id", "Comment", "CreatedDate", "CreatedIp", "CreatedUserId", "ProductId", "Rate", "Status", "ThumbDown", "ThumbsUp", "UpdatedDate", "UpdatedIp", "UpdatedUserId" },
                values: new object[,]
                {
                    { new Guid("94d6b2ee-149e-44a5-8b40-701518d61eea"), "Öncelikle Ürünü alış sebebim laptopu internette bişeyler bakmak, alışveriş yapmak sosyal edyada takılmak için kullanırken ağır olması şarjının çok gitmemesiydi. Ben öyle oyun oynayan biri değilim o yüzden yun performansı açısından bir değerlendirme yapamayacağım. Ürün beklediğim gibi. Bilgisayardan google chrome'a nasıl idiyorsanız bu cihazla da aynen girebiliyorsunuz. Şarj konusuna gelirsek net 6 saat ekran açık İnternette ezinebiliyorsunuz. Cihazın hoparlörlerinden gelen ses çok başarılı ancak kulaklık konusunda çok iddialı değil. Aşağıda orumda arkadaş usb bellekleri görmüyor demiş ben çatır çutur takıyorum gayette görüyor. Cihazın iki kusuru var bence irincisi yeni olduğundan dolayı kılıf olsun ekran koruyucu olsun bu tarz aksesuarlar açısından sıkıntısı var. İkincisi e batarya biraz daha büyük olabilirdi. Ancak şunu da söyleyeyim bu aralar işe gitmiyor oluşum ve cihazın yeni oluşundanötürü sürekli elimde olması da pilini yeterli bulmamamda etkili bir faktördür. Sonuç olarak benim aldığım amaçla lacaklara tavsiye ederim.Kargo gayet hızlı sitenin tahmini olarak size söylediği tarihten 2 gün önce elinize laşıyor.", new DateTime(2021, 10, 4, 20, 47, 43, 409, DateTimeKind.Local).AddTicks(2018), null, new Guid("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"), new Guid("ebf25e2d-15e5-4133-ad82-156f83f4ce96"), "5", 1, 4, 6, null, null, null },
                    { new Guid("88936dd2-d7d0-440e-b569-33b75371eb83"), "Ürün iyi hoş güzel de aga bu nasıl bir dolar kuru, adam bunu 400 500 lira sayıp alıyor biz iye 2 asgari ücretten fazla koyuyoz Allah aşkına ya.  Not: Almanya bizi kıskanıyor :'(", new DateTime(2021, 10, 4, 20, 47, 43, 409, DateTimeKind.Local).AddTicks(2001), null, new Guid("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"), new Guid("cf64d3ff-a595-4f9e-a4d6-11ebc21905aa"), "5", 1, 4, 6, null, null, null },
                    { new Guid("1809e98a-5dcf-48f7-9e55-56a482cc8900"), "Ürün fotoğraflardaki gibi 3 4 saattir kurulum için kullanıyorum gayet hızlı.İstanbul içinde seniz kargo süreci çok hızlı bir şekilde işliyor. Free dos olduğu için format attıktan sonra ilk iş windowsu son sürümegüncelleyin daha sonra kurulum yapın.Lenovo sitesindeki sürücülerin bazıları windows son sürüm olmadığı için kurulmuyorözellikle ekran kartları. Klavye hissiyatı çok iyi. Satıcı ilgili aradığımda direkt çözüm odaklı konuştular. Gerekli azılımları indirmenizi tavsiye ederim. Düşünmeden alabilirsiniz", new DateTime(2021, 10, 4, 20, 47, 43, 409, DateTimeKind.Local).AddTicks(1988), null, new Guid("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"), new Guid("a7630777-3514-46e6-8f46-ff84d48a32a8"), "5", 1, 4, 6, null, null, null },
                    { new Guid("70a8a21d-6541-4e19-8bcf-9ab26569c278"), "Televizyonun Artıları: + iPhone ile tam uyumlu olması + Hızlı açılış süresi + Menülerdeki kıcılık + Fiyat performans ürünü Eksileri - Kanal geçişleri bazen can sıkabiliyor - Menünün bazı kısımları yavaş alışıyor - Görüntü ayarlarında istenen rengi yakalamak olması gerekenden zor. Genel olarak ben üründen memnunum.Daha yi olabilirdi ancak o zamanda tabiki fiyatı daha da yüksek olacaktı.Ayrıca satın aldığım satıcının paketlemesi oldukça yi.Sadece kutusu ile göndermeyip dışına birde kabarcıklı poşet sarması teslimat sırasında kontrol etmenizi çok çok olaylaştırıyor.Satıcının ilgiside gayet iyiydi.Çok teşekkürler.", new DateTime(2021, 10, 4, 20, 47, 43, 409, DateTimeKind.Local).AddTicks(2031), null, new Guid("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"), new Guid("8bc31d49-d44c-43e7-bc87-f9bdd3b37f78"), "5", 1, 4, 6, null, null, null },
                    { new Guid("e66f1413-5c95-4f6f-bfec-912f5950ba24"), "Ürün gayet başarılı, 512 gb ssdli modeli yerine tercih ettim, kurulum sıkıntı oldu, riverleri mutlaka lenovonun kendi sitesinden indirmenizi tavsiye ederim, satıcı güzel, iletişimi iyiydi.", new DateTime(2021, 10, 4, 20, 47, 43, 409, DateTimeKind.Local).AddTicks(1964), null, new Guid("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"), new Guid("49669332-44e1-4696-84c0-9ab229061315"), "5", 1, 4, 6, null, null, null },
                    { new Guid("5455bab6-dc9f-4a7b-9ae0-ae0f68f6762a"), "Öncelikle hızlı kargo gönderimi için Hepsi Buradaya teşekkür ederim. Ürün elime hasarsız bir ekilde ulaştı. Kutulama oldukça başarılı. Ürün gerçekten çok kaliteli. Hem iş hem de oyun amaçlı olarak ullanılabiliyor. Performans olarak Harika bir ürün herkese gönül rahatlığıyla tavsiye ederim.", new DateTime(2021, 10, 4, 20, 47, 43, 409, DateTimeKind.Local).AddTicks(1906), null, new Guid("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"), new Guid("2322717a-d36d-4299-af9f-2b6faedd1423"), "5", 1, 4, 6, null, null, null },
                    { new Guid("e92791ca-9448-42b3-8d4d-7b248963f813"), "cihaz harika ancak 2080 max-q olması desktop versiyonda 2070'e denk geldiği nutulmamalı.Oyunlarda overclocklu hali ile gayet tatmin edici fps'ler sunuyor.tavsiye olunur.", new DateTime(2021, 10, 4, 20, 47, 43, 409, DateTimeKind.Local).AddTicks(421), null, new Guid("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"), new Guid("2322717a-d36d-4299-af9f-2b6faedd1423"), "5", 1, 4, 6, null, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
