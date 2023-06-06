using Domain.Constants;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance.Seeds
{
    internal static class UserSeed
    {
        internal static ModelBuilder AddRoleSeedData(this ModelBuilder builder)
        {
            List<Role> roles = new List<Role>()
            {
                new Role
                {
                    Id = new Guid("84028dce-99cd-4351-bb36-1514c6592e54"),
                    Name = Roles.Admin,
                    NormalizedName = Roles.Admin,
                    NameRu = "Админ",
                    ConcurrencyStamp = "24B4F638-0C83-4526-A143-8E6A3E3F4301"
                },
                new Role
                {
                    Id = new Guid("7b68a169-3cf0-403d-a5b9-8bcf8319ca13"),
                    Name = Roles.Carrier,
                    NormalizedName = Roles.Carrier,
                    NameRu = "Курьер",
                    ConcurrencyStamp = "24B4F638-0C83-4526-A143-8E6A3E3F4301"
                },
                new Role
                {
                    Id = new Guid("df172293-c03c-462d-be88-ba9ad41c8cf7"),
                    Name = Roles.Client,
                    NormalizedName = Roles.Client,
                    NameRu = "Клиент",
                    ConcurrencyStamp = "166C78CC-189E-451C-9944-DE606C116709"
                },
                new Role
                {
                    Id = new Guid("7056419c-e665-4a17-b88c-e5a41237e0fb"),
                    Name = Roles.Employee,
                    NormalizedName = Roles.Employee,
                    NameRu = "Работник",
                    ConcurrencyStamp = "F96B067C-C796-477D-A5EB-3633258DF11E"
                },
                new Role
                {
                    Id = new Guid("5ba00775-fb4a-49a9-a1c4-9c41fc2136dc"),
                    Name = Roles.ShopOwner,
                    NormalizedName = Roles.ShopOwner,
                    NameRu = "Владелец магазина",
                    ConcurrencyStamp = "7B7C2902-1849-4383-A5E1-375923A47DC3"
                },
            };

            builder.Entity<Role>().HasData(roles);
            return builder;
        }

        internal static ModelBuilder AddUserSeedData(this ModelBuilder builder)
        {
            List<User> users = new List<User>()
            {
                new User
                {
                    Id = new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"),
                    Firstname = "Admin",
                    Name = "Admin",
                    Patronymic = "Admin",
                    Address = "admins address",
                    DateOfBirth = DateTime.Now,
                    UserName = "Admin",
                    NormalizedUserName = "Admin".ToUpper(),
                    SecurityStamp = "7C4733BF-0EC3-450D-888A-6CF4A2F570D7",
                    ConcurrencyStamp = "1708A7F2-6382-4822-ACC6-76CFF580F950",
                },
                new User
                {
                    Id = new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"),
                    Firstname = "Искакова",
                    Name = "Нурайым",
                    Patronymic = "Нурлановна",
                    Address = "Исанова 1",
                    DateOfBirth = new DateTime(1997, 10, 1),
                    UserName = "nuraiym",
                    NormalizedUserName = "nuraiym".ToUpper(),
                    SecurityStamp = "283C1078-1EBF-48EC-A039-47A3DA91190E",
                    ConcurrencyStamp = "FBC07588-ABB1-494C-B8AF-75C7D63B4AB5",
                },
                new User
                {
                    Id = new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"),
                    Firstname = "Мамбетов",
                    Name = "Кутман",
                    Patronymic = "Белекович",
                    Address = "Уметалиева 2",
                    DateOfBirth = new DateTime(1996, 10, 1),
                    UserName = "kutman",
                    NormalizedUserName = "kutman".ToUpper(),
                    SecurityStamp = "6E47ECB5-B32B-48E3-812E-C07DD22B59BD",
                    ConcurrencyStamp = "096CCA44-C4C4-47E2-8DBC-B942FB5D2A28",
                },
                new User
                {
                    Id = new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"),
                    Firstname = "Нурланов",
                    Name = "Нурхан",
                    Patronymic = "Нуралнович",
                    Address = "Чуй 152",
                    DateOfBirth = new DateTime(2000, 7, 6),
                    UserName = "nurhan",
                    NormalizedUserName = "nurhan".ToUpper(),
                    SecurityStamp = "CCE59880-F1BF-43C2-BD6A-1787C5A83E73",
                    ConcurrencyStamp = "A856E503-1B54-4B7D-B09D-B33E80655E51",
                },
                new User
                {
                    Id = new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"),
                    Firstname = "Иванов",
                    Name = "Николай",
                    Patronymic = "Васильевич",
                    Address = "Манаса 52",
                    DateOfBirth = new DateTime(1999, 1, 24),
                    UserName = "nikolay",
                    NormalizedUserName = "nikolay".ToUpper(),
                    SecurityStamp = "1214702B-6B5E-42B2-A7B8-78B7EC12CB46",
                    ConcurrencyStamp = "6D2C5F0A-AAB4-4F45-BE91-28D9129A10E8",
                },
            };

            foreach (var item in users)
            {
                item.PasswordHash = new PasswordHasher<User>().HashPassword(item, "12345678");
            }

            builder.Entity<User>().HasData(users);
            return builder;
        }

        internal static ModelBuilder AddUserRoleSeedData(this ModelBuilder builder)
        {
            var userRoles = new List<IdentityUserRole<Guid>>()
            {
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("84028dce-99cd-4351-bb36-1514c6592e54"),
                    UserId = new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040")
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("df172293-c03c-462d-be88-ba9ad41c8cf7"),
                    UserId = new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a")
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("5ba00775-fb4a-49a9-a1c4-9c41fc2136dc"),
                    UserId = new Guid("8eb818e5-6a31-4710-9532-aebb2194776f")
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("7056419c-e665-4a17-b88c-e5a41237e0fb"),
                    UserId = new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898")
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid("7b68a169-3cf0-403d-a5b9-8bcf8319ca13"),
                    UserId = new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e")
                },
            };
            
            builder.Entity<IdentityUserRole<Guid>>().HasData(userRoles);
            return builder;
        }
    }
}