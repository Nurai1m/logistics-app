using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class fixRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_RoleId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "NameRu",
                table: "AspNetRoles");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("7b68a169-3cf0-403d-a5b9-8bcf8319ca13"), new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5ba00775-fb4a-49a9-a1c4-9c41fc2136dc"), new Guid("8eb818e5-6a31-4710-9532-aebb2194776f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("84028dce-99cd-4351-bb36-1514c6592e54"), new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("df172293-c03c-462d-be88-ba9ad41c8cf7"), new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("7056419c-e665-4a17-b88c-e5a41237e0fb"), new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898") });

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUserRoles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "RoleId1",
                table: "AspNetUserRoles",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "AspNetUserRoles",
                type: "uuid",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("7b68a169-3cf0-403d-a5b9-8bcf8319ca13"), new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"), "IdentityUserRole<Guid>" },
                    { new Guid("5ba00775-fb4a-49a9-a1c4-9c41fc2136dc"), new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"), "IdentityUserRole<Guid>" },
                    { new Guid("84028dce-99cd-4351-bb36-1514c6592e54"), new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"), "IdentityUserRole<Guid>" },
                    { new Guid("df172293-c03c-462d-be88-ba9ad41c8cf7"), new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"), "IdentityUserRole<Guid>" },
                    { new Guid("7056419c-e665-4a17-b88c-e5a41237e0fb"), new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"), "IdentityUserRole<Guid>" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECWexzIkbET7GQwhfrg1rLSxqhh7L3rlq9ioTOnbrZTB0rqR/kH+cqVNuI00gZVE7w==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAZFaAB2GLcb0aJg+mCDEQq3IU674/2xacMyjpj9fkD3+AHMmwAcGHf4Bb+ST2Th9Q==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"),
                columns: new[] { "DateOfBirth", "PasswordHash" },
                values: new object[] { new DateTime(2023, 6, 6, 22, 17, 11, 706, DateTimeKind.Local).AddTicks(6628), "AQAAAAEAACcQAAAAECQOBb4zKXF/D4yKtJG1as3URMCRvfG+no6UwFxxfW+LOVh0Y4u9s2qjjSlusEb4cw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEB+59B7Nn0T6Hqj85Rac6NeOXP+4yCobolTzfFsaPwImgAGsifCKgV85t/H9ZyfwVg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"),
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFZXiVV6/DV3vtDCstNKgNzRRZy6CLgCUqwtmAR1p3Vk74mTXxBdudHx/twjQExCCw==");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId1",
                table: "AspNetUserRoles",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId1",
                table: "AspNetUserRoles",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId1",
                table: "AspNetUserRoles",
                column: "RoleId1",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId1",
                table: "AspNetUserRoles",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
