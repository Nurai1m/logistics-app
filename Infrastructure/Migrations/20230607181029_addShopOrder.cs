using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class addShopOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ShopId",
                table: "Orders",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECg9Zn2XHriZH+ofWtSROdP5B3GnwpCsLROF1ZELlwMgzpJZFCvXVx454oBo0EntPg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAEkbZ74PQCABwRMIfhjTkZ09T+Eh+IBEi906SWIr+xDqdfVp8AEE73UAq/e6oVFUw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"),
                columns: new[] { "DateOfBirth", "PasswordHash" },
                values: new object[] { new DateTime(2023, 6, 8, 0, 10, 28, 772, DateTimeKind.Local).AddTicks(4961), "AQAAAAEAACcQAAAAENGP5poX54xJB8lP+14L+a+aNplnqIU/treNpNMEeOSIbafcd8boOUo7BJcI0M9mjQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEF/m9eQdfP/heqvJjj9VI95mwqIYvdt8lE476hCUE3tOuCvXuR5K3fDp7B2CaGTBUQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKA273HnjjWxJyKssOKow3j0XkwR7bdYdjmMeLuRH9hOMi7yzH3zINVE3F7yTkNC9g==");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShopId",
                table: "Orders",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shops_ShopId",
                table: "Orders",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shops_ShopId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ShopId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEMMYVC8Dv61Ip+vQo06x4QtMmNqUfsNjGbGswAvSVQb98GF//t30+35h4R9ZcSb2w==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGsmoZnyu0L/1WQ6wlDpbhoDhB11pdXQUNmXcHzd0LCr4gpyvB14l8mFtMRdkxGwdg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"),
                columns: new[] { "DateOfBirth", "PasswordHash" },
                values: new object[] { new DateTime(2023, 6, 7, 23, 30, 49, 318, DateTimeKind.Local).AddTicks(8188), "AQAAAAEAACcQAAAAEPxj9yy05V6ZDUovu9dMCp6h7g/FhooLtxVUU1ckUFJ4/2Hs2MSMtaXDqJWSKZWuHw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGIbNTs5gC5XCIN90DcMuUOgG8Vy+upquucBdP0ARP1mWT0LtXgJWo+zrVN89jySaA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJKGHb0nVmWlB3AhDCPVkTILdxtQtwjGfxb5hRY0IkeNLLHgnBk8jw8/Ziwv3ijbkg==");
        }
    }
}
