using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommercialSite.Model.Migrations
{
    public partial class NewInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "BillingAddresses",
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
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    SurName = table.Column<string>(maxLength: 100, nullable: false),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    Location = table.Column<string>(maxLength: 50, nullable: false),
                    SubLocation = table.Column<string>(maxLength: 50, nullable: false),
                    Adress = table.Column<string>(maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 15, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingAddresses_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BillingAddresses_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BillingAddresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteProducts",
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
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteProducts_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FavoriteProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteProducts_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FavoriteProducts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentInfos",
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
                    ShipmentName = table.Column<string>(maxLength: 50, nullable: false),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipmentInfos_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShipmentInfos_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShipmentInfos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShippingAddresses",
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
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    SurName = table.Column<string>(maxLength: 100, nullable: false),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    Location = table.Column<string>(maxLength: 50, nullable: false),
                    SubLocation = table.Column<string>(maxLength: 50, nullable: false),
                    Adress = table.Column<string>(maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 15, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShippingAddresses_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShippingAddresses_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShippingAddresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderInfos",
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
                    ShippingFirstName = table.Column<string>(maxLength: 100, nullable: false),
                    ShippingSurname = table.Column<string>(maxLength: 100, nullable: false),
                    ShippingAddress = table.Column<string>(maxLength: 255, nullable: false),
                    ShippingPhoneNumber = table.Column<string>(maxLength: 15, nullable: false),
                    ShippingCountry = table.Column<string>(maxLength: 50, nullable: false),
                    ShippingLocation = table.Column<string>(maxLength: 50, nullable: false),
                    ShippingSubLocation = table.Column<string>(maxLength: 50, nullable: false),
                    ShippingEmail = table.Column<string>(nullable: false),
                    BillingFirstName = table.Column<string>(maxLength: 100, nullable: false),
                    BillingSurname = table.Column<string>(maxLength: 100, nullable: false),
                    BillingAddress = table.Column<string>(maxLength: 255, nullable: false),
                    BillingPhoneNumber = table.Column<string>(maxLength: 15, nullable: false),
                    BillingCountry = table.Column<string>(maxLength: 50, nullable: false),
                    BillingLocation = table.Column<string>(maxLength: 50, nullable: false),
                    BillingSubLocation = table.Column<string>(maxLength: 50, nullable: false),
                    BillingEmail = table.Column<string>(nullable: false),
                    ShipmentInfoId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderInfos_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderInfos_ShipmentInfos_ShipmentInfoId",
                        column: x => x.ShipmentInfoId,
                        principalTable: "ShipmentInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderInfos_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderInfos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
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
                    UserId = table.Column<Guid>(nullable: false),
                    OrderInfoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_OrderInfos_OrderInfoId",
                        column: x => x.OrderInfoId,
                        principalTable: "OrderInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

           

            migrationBuilder.CreateIndex(
                name: "IX_BillingAddresses_CreatedUserId",
                table: "BillingAddresses",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingAddresses_UpdatedUserId",
                table: "BillingAddresses",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingAddresses_UserId",
                table: "BillingAddresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProducts_CreatedUserId",
                table: "FavoriteProducts",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProducts_ProductId",
                table: "FavoriteProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProducts_UpdatedUserId",
                table: "FavoriteProducts",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProducts_UserId",
                table: "FavoriteProducts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderInfos_CreatedUserId",
                table: "OrderInfos",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderInfos_ShipmentInfoId",
                table: "OrderInfos",
                column: "ShipmentInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderInfos_UpdatedUserId",
                table: "OrderInfos",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderInfos_UserId",
                table: "OrderInfos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CreatedUserId",
                table: "Orders",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderInfoId",
                table: "Orders",
                column: "OrderInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UpdatedUserId",
                table: "Orders",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentInfos_CreatedUserId",
                table: "ShipmentInfos",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentInfos_UpdatedUserId",
                table: "ShipmentInfos",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentInfos_UserId",
                table: "ShipmentInfos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddresses_CreatedUserId",
                table: "ShippingAddresses",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddresses_UpdatedUserId",
                table: "ShippingAddresses",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddresses_UserId",
                table: "ShippingAddresses",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
