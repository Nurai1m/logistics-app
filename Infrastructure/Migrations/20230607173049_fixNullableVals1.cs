using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class fixNullableVals1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKlT1vkB0jYbt5g+A5OuYTmdYMKDEfZQgQ07K/ogw8y5+cNT9STjdiMTOo4pABNn0w==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFalQlATh9FjvKeZ4NV4MLnAs7SvuBtLtjRuw/ksp65OJnAFve2lfMBeJS3C6VZmuA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"),
                columns: new[] { "DateOfBirth", "PasswordHash" },
                values: new object[] { new DateTime(2023, 6, 7, 23, 26, 47, 203, DateTimeKind.Local).AddTicks(2643), "AQAAAAEAACcQAAAAEBGMeQuzp5XpY90WQFDaPEvo5NvPEnoOv9Y1TFMaYjsCBZaWaocHCCTqWj46jbibrg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJbS0Rd9Bg32A4ZZahj0YhM1glefIroaj/85YYxbx3CwDkkCKOGo4DtBY0jn3pLf0A==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAwzANN2usLKo1hqn8Fq83REG1nyEZHNu5IOcNE0VHnDnGIZD/B7yDVZRdiyMZfYtQ==");
        }
    }
}
