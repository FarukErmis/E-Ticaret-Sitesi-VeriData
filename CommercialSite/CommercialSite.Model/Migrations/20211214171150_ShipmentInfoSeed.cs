using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommercialSite.Model.Migrations
{
    public partial class ShipmentInfoSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "ShipmentInfos",
                columns: new[] { "Id", "CreatedDate", "CreatedIp", "CreatedUserId", "ShipmentName", "Status", "UpdatedDate", "UpdatedIp", "UpdatedUserId", "UserId" },
                values: new object[] { new Guid("59071398-7481-462d-809a-d99413a4a5e3"), null, null, null, "JetTekno", 1, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
