using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class addOrderField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_СarrierId",
                table: "Orders");

            migrationBuilder.AlterColumn<Guid>(
                name: "СarrierId",
                table: "Orders",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<Guid>(
                name: "ShopLocationId",
                table: "Orders",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEARtb9dT7se5M9iXHon51FCMBMDfGotUWGv3G1sP9DGE4W/g4Oolas6saTTg4XZkDQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGfjhomz2pzH8NhGuFyre8vEYPtJbzOlnYjvz3dDvR2S4I/zFFUUI/uovTKx0n4oiA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"),
                columns: new[] { "DateOfBirth", "PasswordHash" },
                values: new object[] { new DateTime(2023, 6, 10, 23, 7, 21, 816, DateTimeKind.Local).AddTicks(274), "AQAAAAEAACcQAAAAEJjLhUKSAZIRl3vhVuWdn5pFMT18a0X2pDkbNH5AIGdgaQ/5r9MNtMYX0ERnCSo5TA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELpjwIWzFRnFXJWQxRpfIK5Bq3H62Wj8AszeKZ1JSKYUE+snhNojcJ18xUiTNAZF5Q==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPGBnKEetXfSLpxG2xNjBKnlbuNA4hFpXvyQHpg/qT2MuLB8bGrmYwGTc1vINS3OfQ==");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_СarrierId",
                table: "Orders",
                column: "СarrierId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_СarrierId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShopLocationId",
                table: "Orders");

            migrationBuilder.AlterColumn<Guid>(
                name: "СarrierId",
                table: "Orders",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_СarrierId",
                table: "Orders",
                column: "СarrierId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
