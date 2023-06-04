using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class add_seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Patronymic",
                table: "AspNetUsers",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "VehicleInfo",
                table: "AspNetUsers",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("5ba00775-fb4a-49a9-a1c4-9c41fc2136dc"), "7B7C2902-1849-4383-A5E1-375923A47DC3", "shopOwner", "shopOwner" },
                    { new Guid("7056419c-e665-4a17-b88c-e5a41237e0fb"), "F96B067C-C796-477D-A5EB-3633258DF11E", "employee", "employee" },
                    { new Guid("7b68a169-3cf0-403d-a5b9-8bcf8319ca13"), "24B4F638-0C83-4526-A143-8E6A3E3F4301", "carrier", "carrier" },
                    { new Guid("84028dce-99cd-4351-bb36-1514c6592e54"), "24B4F638-0C83-4526-A143-8E6A3E3F4301", "admin", "admin" },
                    { new Guid("df172293-c03c-462d-be88-ba9ad41c8cf7"), "166C78CC-189E-451C-9944-DE606C116709", "client", "client" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Patronymic", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VehicleInfo" },
                values: new object[,]
                {
                    { new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"), 0, "Манаса 52", "6D2C5F0A-AAB4-4F45-BE91-28D9129A10E8", new DateTime(1999, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Иванов", false, null, "Николай", null, "NIKOLAY", "AQAAAAEAACcQAAAAEE2OUgjkBYY7MDk51Cl5NEK5HdaGJ8IOBc8euhkXYT81gndXIDsbkJWFMFiifMuWnQ==", "Васильевич", null, false, "1214702B-6B5E-42B2-A7B8-78B7EC12CB46", false, "nikolay", null },
                    { new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"), 0, "Уметалиева 2", "096CCA44-C4C4-47E2-8DBC-B942FB5D2A28", new DateTime(1996, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Мамбетов", false, null, "Кутман", null, "KUTMAN", "AQAAAAEAACcQAAAAEBhp9f+NtF6CNwkgCKvlPaKfofTxos9JPwTIFsRnRuCMIUJr6m6Ue4IiPTAyL6bhYg==", "Белекович", null, false, "6E47ECB5-B32B-48E3-812E-C07DD22B59BD", false, "kutman", null },
                    { new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"), 0, "admins address", "1708A7F2-6382-4822-ACC6-76CFF580F950", new DateTime(2023, 6, 4, 20, 8, 25, 801, DateTimeKind.Local).AddTicks(4730), null, false, "Admin", false, null, "Admin", null, "ADMIN", "AQAAAAEAACcQAAAAENZgTdclC0Y1h1LslS6CcwGY5lYbUv2lriaTU9mEr7KxMY9kvI+t2NmP9dbpl+8N8w==", "Admin", null, false, "7C4733BF-0EC3-450D-888A-6CF4A2F570D7", false, "Admin", null },
                    { new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"), 0, "Исанова 1", "FBC07588-ABB1-494C-B8AF-75C7D63B4AB5", new DateTime(1997, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Искакова", false, null, "Нурайым", null, "NURAIYM", "AQAAAAEAACcQAAAAEMJiFxAovWfK0aijfr68SRlNjPbQkpFoCtEkLuWaP7RSzQ+j9TWo9wbb1wmmM7/8Mw==", "Нурлановна", null, false, "283C1078-1EBF-48EC-A039-47A3DA91190E", false, "nuraiym", null },
                    { new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"), 0, "Чуй 152", "A856E503-1B54-4B7D-B09D-B33E80655E51", new DateTime(2000, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Нурланов", false, null, "Нурхан", null, "NURHAN", "AQAAAAEAACcQAAAAED0BPplNECjEQNymCi0fDj39D5DVbzRHpzl5uDPGob4/wdoHibFJ7Qn+Qux6u0ZX+g==", "Нуралнович", null, false, "CCE59880-F1BF-43C2-BD6A-1787C5A83E73", false, "nurhan", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7b68a169-3cf0-403d-a5b9-8bcf8319ca13"), new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e") },
                    { new Guid("5ba00775-fb4a-49a9-a1c4-9c41fc2136dc"), new Guid("8eb818e5-6a31-4710-9532-aebb2194776f") },
                    { new Guid("84028dce-99cd-4351-bb36-1514c6592e54"), new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040") },
                    { new Guid("df172293-c03c-462d-be88-ba9ad41c8cf7"), new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a") },
                    { new Guid("7056419c-e665-4a17-b88c-e5a41237e0fb"), new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898") }
                });
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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5ba00775-fb4a-49a9-a1c4-9c41fc2136dc"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7056419c-e665-4a17-b88c-e5a41237e0fb"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7b68a169-3cf0-403d-a5b9-8bcf8319ca13"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("84028dce-99cd-4351-bb36-1514c6592e54"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("df172293-c03c-462d-be88-ba9ad41c8cf7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"));

            migrationBuilder.DropColumn(
                name: "VehicleInfo",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Patronymic",
                table: "AspNetUsers",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200,
                oldNullable: true);
        }
    }
}
