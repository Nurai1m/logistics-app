using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class addRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameRu",
                table: "AspNetRoles",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5ba00775-fb4a-49a9-a1c4-9c41fc2136dc"),
                column: "NameRu",
                value: "Владелец магазина");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7056419c-e665-4a17-b88c-e5a41237e0fb"),
                column: "NameRu",
                value: "Работник");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7b68a169-3cf0-403d-a5b9-8bcf8319ca13"),
                column: "NameRu",
                value: "Курьер");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("84028dce-99cd-4351-bb36-1514c6592e54"),
                column: "NameRu",
                value: "Админ");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("df172293-c03c-462d-be88-ba9ad41c8cf7"),
                column: "NameRu",
                value: "Клиент");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJI6jeBKjiuPH3R3z4OG/lWBy7uueUm3oLveXvjOMinN+qp6A5SxSsJ/kbkz/+HNng==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBnq4T6MTuAnZeL87lxnwJyTavNjyVDWyd5QeuTmAJmJ+XInP1wTrF3Dm0bN7cwcpA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"),
                columns: new[] { "DateOfBirth", "PasswordHash" },
                values: new object[] { new DateTime(2023, 6, 6, 20, 13, 47, 136, DateTimeKind.Local).AddTicks(312), "AQAAAAEAACcQAAAAELnBvlE4+W/w5AcHzmxbPu6MuUiQLhAFi1G05c2+bmst7JXv225guhVXk2XiuZlnNg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBileRURHQb+naR0JWx77GH9oXxBqSACd7LCss+BaFTU1oNUlNPrng9bk988XsGKyA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAM+rALmryPt5jJc6UpB9YmfvUd9+yvr0r37c/U57Xufp2nsM43TE7IcYpjPM4LB1A==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameRu",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEE2OUgjkBYY7MDk51Cl5NEK5HdaGJ8IOBc8euhkXYT81gndXIDsbkJWFMFiifMuWnQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEBhp9f+NtF6CNwkgCKvlPaKfofTxos9JPwTIFsRnRuCMIUJr6m6Ue4IiPTAyL6bhYg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"),
                columns: new[] { "DateOfBirth", "PasswordHash" },
                values: new object[] { new DateTime(2023, 6, 4, 20, 8, 25, 801, DateTimeKind.Local).AddTicks(4730), "AQAAAAEAACcQAAAAENZgTdclC0Y1h1LslS6CcwGY5lYbUv2lriaTU9mEr7KxMY9kvI+t2NmP9dbpl+8N8w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMJiFxAovWfK0aijfr68SRlNjPbQkpFoCtEkLuWaP7RSzQ+j9TWo9wbb1wmmM7/8Mw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAED0BPplNECjEQNymCi0fDj39D5DVbzRHpzl5uDPGob4/wdoHibFJ7Qn+Qux6u0ZX+g==");
        }
    }
}
