using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class fixNullableVals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Lat",
                table: "Orders",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Lang",
                table: "Orders",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Orders",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(1000)",
                oldMaxLength: 1000);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Lat",
                table: "Orders",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Lang",
                table: "Orders",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Orders",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

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
    }
}
