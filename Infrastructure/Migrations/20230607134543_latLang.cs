using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class latLang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lang",
                table: "Orders",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lat",
                table: "Orders",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGQfaSHOS+Fep0tySj0N3Gx9S3ZThPYhM30Pd1RBk1bJJdibMDLhuWODkWWc0hGmNQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMi75VNvQmbBf0v0kt3xt8dySF1WAKYCvxe5hs2k1r91CsAFFwwlKa2hEjWjqHcPew==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"),
                columns: new[] { "DateOfBirth", "PasswordHash" },
                values: new object[] { new DateTime(2023, 6, 7, 19, 45, 42, 965, DateTimeKind.Local).AddTicks(9215), "AQAAAAEAACcQAAAAEAK3k9LhiDy/YE8wtcYEkRbJTHcARedWHDBLMNxudCTEBWln9tztcG0XnuD4ebrN1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDaE3dtxDBx2eCzrOtDLbkHQu9tYbqO6MPN3MDytp+4swo/PDqQRVnlwfLD+qmO2qQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAS/Zi7DFI1zJINAdSL6d6FctATB6wxPvba2PM7mPmaqGJat12HNeVomWXooMceZ0g==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lang",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Lat",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENLQXrnDiLX0U0ZsxKV8lML+JGoGKNN4E8JuBOFMB7KPX1BC5iCpdDxDQxMFGKvwgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPwMlpjinoKyNsWNeso2gLMTC5aI1WlDRTZ4c7KFJaN8yyCkLXuqyuFZoA/6bN3DRQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"),
                columns: new[] { "DateOfBirth", "PasswordHash" },
                values: new object[] { new DateTime(2023, 6, 7, 10, 26, 36, 186, DateTimeKind.Local).AddTicks(5556), "AQAAAAEAACcQAAAAEA0AoG51CakUDrRp5BM8BhgolAy0uSxiCtAEbLMahevz5BW8RC/9FAbestD0mlngEA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJHTY8JEmyX4wdjgGkOD2yycWIJFVTcK9EJEIDNZLFAl2K1XiffItIQYooe2X/qucQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELJ2s9lt8USdGg7faCf3F9HC0qugJlOULSOx9tfNMp58rVOZDL3aQNZfaH3gzXZ3Ug==");
        }
    }
}
