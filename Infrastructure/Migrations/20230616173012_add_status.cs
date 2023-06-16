using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class add_status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderStatus",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIh4tjYOAwrMQePYV3LtN7VWgVd0VZHwVvUeGuXH/LSv0B9C/qBA0JraosiGxhxuHw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEChUCX3kEs7xFdi6lhaP4AFo62oK/+MTrmjOJf5p6h13MnNBlWAo/K3h2WL3YWCUFQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"),
                columns: new[] { "DateOfBirth", "PasswordHash" },
                values: new object[] { new DateTime(2023, 6, 16, 23, 30, 12, 189, DateTimeKind.Local).AddTicks(6581), "AQAAAAEAACcQAAAAEAe4zC2eye2Ksw/zK0+Cz7jxkqb66MMNU94DzVE30CHmEQj2O/Xb0H0WivA7ufrJsw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPAPC3z28QgbEUcd144K9r0QZb+lJ/d3zJmkM/x1V2mjrnH1+MAhiNU1t4KUTh1wmg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOqmjN1LgOYya5ozTs3JQ9GegNkVJFfRV71Rj+jUnookeu7FykgHe8ONMG5QynHTQw==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "Orders");

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
        }
    }
}
