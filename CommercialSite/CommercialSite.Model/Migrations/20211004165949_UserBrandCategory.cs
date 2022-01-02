using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommercialSite.Model.Migrations
{
    public partial class UserBrandCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    CreatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<Guid>(nullable: true),
                    UpdatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 15, nullable: false),
                    Title = table.Column<string>(maxLength: 20, nullable: true),
                    AvatarUrl = table.Column<string>(maxLength: 255, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 12, nullable: false),
                    LastIPAddress = table.Column<string>(maxLength: 15, nullable: true),
                    LastLogin = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    CreatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<Guid>(nullable: true),
                    UpdatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    BrandName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Brands_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    CreatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<Guid>(nullable: true),
                    UpdatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    CategoryName = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categories_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    CreatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<Guid>(nullable: true),
                    UpdatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    TCKN = table.Column<string>(maxLength: 11, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 11, nullable: true),
                    BirthDate = table.Column<DateTime>(maxLength: 11, nullable: true),
                    Gender = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetails_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserDetails_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    CreatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<Guid>(nullable: true),
                    UpdatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    CategoryId = table.Column<Guid>(nullable: false),
                    BrandId = table.Column<Guid>(nullable: false),
                    ProductName = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    WithoutDiscountPrice = table.Column<double>(nullable: false),
                    DiscountPrice = table.Column<double>(nullable: true),
                    Rate = table.Column<int>(nullable: true),
                    ReviewNumber = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    CreatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<Guid>(nullable: true),
                    UpdatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    ProductId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: false),
                    Rate = table.Column<string>(nullable: false),
                    ThumbsUp = table.Column<int>(nullable: true),
                    ThumbDown = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductComments_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductComments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductComments_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    CreatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<Guid>(nullable: true),
                    UpdatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    ProductId = table.Column<Guid>(nullable: false),
                    ImageUrl = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductImages_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductProperties",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    CreatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<Guid>(nullable: true),
                    UpdatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    ProductId = table.Column<Guid>(nullable: false),
                    VarKey = table.Column<string>(maxLength: 50, nullable: false),
                    VarValue = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductProperties_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductProperties_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProperties_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShippingSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    CreatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<Guid>(nullable: true),
                    UpdatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    ProductId = table.Column<Guid>(nullable: false),
                    IsShippingFree = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShippingSettings_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShippingSettings_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShippingSettings_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommentReactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    CreatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<Guid>(nullable: true),
                    UpdatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    ProductCommentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentReactions_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentReactions_ProductComments_ProductCommentId",
                        column: x => x.ProductCommentId,
                        principalTable: "ProductComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentReactions_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedUserId = table.Column<Guid>(nullable: true),
                    CreatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedUserId = table.Column<Guid>(nullable: true),
                    UpdatedIp = table.Column<string>(maxLength: 15, nullable: true),
                    ProductId = table.Column<Guid>(nullable: false),
                    ProductCommentId = table.Column<Guid>(nullable: false),
                    ProductPropertyId = table.Column<Guid>(nullable: false),
                    ProductImageId = table.Column<Guid>(nullable: false),
                    ShippingSettingId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductDetails_ProductComments_ProductCommentId",
                        column: x => x.ProductCommentId,
                        principalTable: "ProductComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_ProductImages_ProductImageId",
                        column: x => x.ProductImageId,
                        principalTable: "ProductImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_ProductProperties_ProductPropertyId",
                        column: x => x.ProductPropertyId,
                        principalTable: "ProductProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_ShippingSettings_ShippingSettingId",
                        column: x => x.ShippingSettingId,
                        principalTable: "ShippingSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName", "CreatedDate", "CreatedIp", "CreatedUserId", "Status", "UpdatedDate", "UpdatedIp", "UpdatedUserId" },
                values: new object[,]
                {
                    { new Guid("2cb8bfab-ff82-41bd-bf39-84d3e5b6ef89"), "ACER", null, null, null, 1, null, null, null },
                    { new Guid("af6273bb-dc30-4a61-9aeb-8225636f564a"), "Lenovo", null, null, null, 1, null, null, null },
                    { new Guid("076bff1f-6c72-4eca-9bf9-1fe491a108b4"), "Samsung", null, null, null, 1, null, null, null },
                    { new Guid("877bdb84-f2f3-4143-aae4-b1a5e6103781"), "Apple", null, null, null, 1, null, null, null },
                    { new Guid("ad3869c4-0631-4d56-8fc3-12b9afd7d40a"), "Xiaomi", null, null, null, 1, null, null, null },
                    { new Guid("14534656-c0d2-44cf-922c-6fc83a21c203"), "Oppo", null, null, null, 1, null, null, null },
                    { new Guid("6520d7be-be4d-4b0d-a222-7e3d90c42de1"), "Philips", null, null, null, 1, null, null, null },
                    { new Guid("1a7c509d-42e2-4213-a944-212f07222084"), "LG", null, null, null, 1, null, null, null },
                    { new Guid("e49c6a75-5835-471e-918a-3345bbb26809"), "Reeder", null, null, null, 1, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "CreatedIp", "CreatedUserId", "Description", "Status", "UpdatedDate", "UpdatedIp", "UpdatedUserId" },
                values: new object[,]
                {
                    { new Guid("9361933a-b73c-4d1d-9dd1-ecfc816b3e6d"), "Bilgisayar", null, null, null, null, 1, null, null, null },
                    { new Guid("afa8a153-6eed-4ad2-a453-dc6d2f86caab"), "Telefon", null, null, null, null, 1, null, null, null },
                    { new Guid("8d0de41d-191a-469f-8909-61c169df2d8e"), "Tablet", null, null, null, null, 1, null, null, null },
                    { new Guid("21f8242e-dd3a-4280-85ad-3bce8bbe4c8c"), "Televizyon", null, null, null, null, 1, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarUrl", "CreatedDate", "CreatedIp", "CreatedUserId", "Email", "FirstName", "LastIPAddress", "LastLogin", "LastName", "Password", "Status", "Title", "UpdatedDate", "UpdatedIp", "UpdatedUserId" },
                values: new object[] { new Guid("88fe5ec9-7b96-4a90-be4d-06a69d95ef42"), "/", null, null, null, "admin@admin.com", "Admin", "127.0.0.1", new DateTime(2021, 10, 4, 19, 59, 48, 895, DateTimeKind.Local).AddTicks(9116), "Admin", "123", 1, "admin", null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Brands_CreatedUserId",
                table: "Brands",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_UpdatedUserId",
                table: "Brands",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreatedUserId",
                table: "Categories",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UpdatedUserId",
                table: "Categories",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentReactions_CreatedUserId",
                table: "CommentReactions",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentReactions_ProductCommentId",
                table: "CommentReactions",
                column: "ProductCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentReactions_UpdatedUserId",
                table: "CommentReactions",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_CreatedUserId",
                table: "ProductComments",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_ProductId",
                table: "ProductComments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_UpdatedUserId",
                table: "ProductComments",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_CreatedUserId",
                table: "ProductDetails",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductCommentId",
                table: "ProductDetails",
                column: "ProductCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductId",
                table: "ProductDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductImageId",
                table: "ProductDetails",
                column: "ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductPropertyId",
                table: "ProductDetails",
                column: "ProductPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ShippingSettingId",
                table: "ProductDetails",
                column: "ShippingSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_UpdatedUserId",
                table: "ProductDetails",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_CreatedUserId",
                table: "ProductImages",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_UpdatedUserId",
                table: "ProductImages",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProperties_CreatedUserId",
                table: "ProductProperties",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProperties_ProductId",
                table: "ProductProperties",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProperties_UpdatedUserId",
                table: "ProductProperties",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CreatedUserId",
                table: "Products",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UpdatedUserId",
                table: "Products",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingSettings_CreatedUserId",
                table: "ShippingSettings",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingSettings_ProductId",
                table: "ShippingSettings",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingSettings_UpdatedUserId",
                table: "ShippingSettings",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_CreatedUserId",
                table: "UserDetails",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_UpdatedUserId",
                table: "UserDetails",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_UserId",
                table: "UserDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreatedUserId",
                table: "Users",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UpdatedUserId",
                table: "Users",
                column: "UpdatedUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentReactions");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "ProductComments");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductProperties");

            migrationBuilder.DropTable(
                name: "ShippingSettings");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
