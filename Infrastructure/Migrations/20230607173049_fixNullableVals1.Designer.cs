﻿// <auto-generated />
using System;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(LogisticEFContext))]
    [Migration("20230607173049_fixNullableVals1")]
    partial class fixNullableVals1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<int>("DeliveryType")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Lang")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Lat")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("TreckingNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<Guid?>("СarrierId")
                        .IsRequired()
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("СarrierId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Domain.Entities.OrderProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("OrderProductId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ShopProductId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("OrderProductId");

                    b.HasIndex("ShopProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("Domain.Entities.ProductDictionary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("VendorCode")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.HasKey("Id");

                    b.ToTable("ProductDictionary");
                });

            modelBuilder.Entity("Domain.Entities.Shop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("Domain.Entities.ShopLocation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Lang")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<Guid>("ShopId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("ShopLocations");
                });

            modelBuilder.Entity("Domain.Entities.ShopProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ShopId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShopId");

                    b.ToTable("ShopProducts");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("VehicleInfo")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"),
                            AccessFailedCount = 0,
                            Address = "admins address",
                            ConcurrencyStamp = "1708A7F2-6382-4822-ACC6-76CFF580F950",
                            DateOfBirth = new DateTime(2023, 6, 7, 23, 30, 49, 318, DateTimeKind.Local).AddTicks(8188),
                            EmailConfirmed = false,
                            Firstname = "Admin",
                            LockoutEnabled = false,
                            Name = "Admin",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEPxj9yy05V6ZDUovu9dMCp6h7g/FhooLtxVUU1ckUFJ4/2Hs2MSMtaXDqJWSKZWuHw==",
                            Patronymic = "Admin",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7C4733BF-0EC3-450D-888A-6CF4A2F570D7",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"),
                            AccessFailedCount = 0,
                            Address = "Исанова 1",
                            ConcurrencyStamp = "FBC07588-ABB1-494C-B8AF-75C7D63B4AB5",
                            DateOfBirth = new DateTime(1997, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailConfirmed = false,
                            Firstname = "Искакова",
                            LockoutEnabled = false,
                            Name = "Нурайым",
                            NormalizedUserName = "NURAIYM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGIbNTs5gC5XCIN90DcMuUOgG8Vy+upquucBdP0ARP1mWT0LtXgJWo+zrVN89jySaA==",
                            Patronymic = "Нурлановна",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "283C1078-1EBF-48EC-A039-47A3DA91190E",
                            TwoFactorEnabled = false,
                            UserName = "nuraiym"
                        },
                        new
                        {
                            Id = new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"),
                            AccessFailedCount = 0,
                            Address = "Уметалиева 2",
                            ConcurrencyStamp = "096CCA44-C4C4-47E2-8DBC-B942FB5D2A28",
                            DateOfBirth = new DateTime(1996, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailConfirmed = false,
                            Firstname = "Мамбетов",
                            LockoutEnabled = false,
                            Name = "Кутман",
                            NormalizedUserName = "KUTMAN",
                            PasswordHash = "AQAAAAEAACcQAAAAEGsmoZnyu0L/1WQ6wlDpbhoDhB11pdXQUNmXcHzd0LCr4gpyvB14l8mFtMRdkxGwdg==",
                            Patronymic = "Белекович",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6E47ECB5-B32B-48E3-812E-C07DD22B59BD",
                            TwoFactorEnabled = false,
                            UserName = "kutman"
                        },
                        new
                        {
                            Id = new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"),
                            AccessFailedCount = 0,
                            Address = "Чуй 152",
                            ConcurrencyStamp = "A856E503-1B54-4B7D-B09D-B33E80655E51",
                            DateOfBirth = new DateTime(2000, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailConfirmed = false,
                            Firstname = "Нурланов",
                            LockoutEnabled = false,
                            Name = "Нурхан",
                            NormalizedUserName = "NURHAN",
                            PasswordHash = "AQAAAAEAACcQAAAAEJKGHb0nVmWlB3AhDCPVkTILdxtQtwjGfxb5hRY0IkeNLLHgnBk8jw8/Ziwv3ijbkg==",
                            Patronymic = "Нуралнович",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "CCE59880-F1BF-43C2-BD6A-1787C5A83E73",
                            TwoFactorEnabled = false,
                            UserName = "nurhan"
                        },
                        new
                        {
                            Id = new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"),
                            AccessFailedCount = 0,
                            Address = "Манаса 52",
                            ConcurrencyStamp = "6D2C5F0A-AAB4-4F45-BE91-28D9129A10E8",
                            DateOfBirth = new DateTime(1999, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailConfirmed = false,
                            Firstname = "Иванов",
                            LockoutEnabled = false,
                            Name = "Николай",
                            NormalizedUserName = "NIKOLAY",
                            PasswordHash = "AQAAAAEAACcQAAAAEEMMYVC8Dv61Ip+vQo06x4QtMmNqUfsNjGbGswAvSVQb98GF//t30+35h4R9ZcSb2w==",
                            Patronymic = "Васильевич",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1214702B-6B5E-42B2-A7B8-78B7EC12CB46",
                            TwoFactorEnabled = false,
                            UserName = "nikolay"
                        });
                });

            modelBuilder.Entity("Domain.Entities.UserShop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ShopId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.HasIndex("UserId");

                    b.ToTable("UserShops");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("84028dce-99cd-4351-bb36-1514c6592e54"),
                            ConcurrencyStamp = "24B4F638-0C83-4526-A143-8E6A3E3F4301",
                            Name = "admin",
                            NormalizedName = "admin"
                        },
                        new
                        {
                            Id = new Guid("7b68a169-3cf0-403d-a5b9-8bcf8319ca13"),
                            ConcurrencyStamp = "24B4F638-0C83-4526-A143-8E6A3E3F4301",
                            Name = "carrier",
                            NormalizedName = "carrier"
                        },
                        new
                        {
                            Id = new Guid("df172293-c03c-462d-be88-ba9ad41c8cf7"),
                            ConcurrencyStamp = "166C78CC-189E-451C-9944-DE606C116709",
                            Name = "client",
                            NormalizedName = "client"
                        },
                        new
                        {
                            Id = new Guid("7056419c-e665-4a17-b88c-e5a41237e0fb"),
                            ConcurrencyStamp = "F96B067C-C796-477D-A5EB-3633258DF11E",
                            Name = "employee",
                            NormalizedName = "employee"
                        },
                        new
                        {
                            Id = new Guid("5ba00775-fb4a-49a9-a1c4-9c41fc2136dc"),
                            ConcurrencyStamp = "7B7C2902-1849-4383-A5E1-375923A47DC3",
                            Name = "shopOwner",
                            NormalizedName = "shopOwner"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("b6dbe22d-cc2f-4063-88d9-280b0f951040"),
                            RoleId = new Guid("84028dce-99cd-4351-bb36-1514c6592e54")
                        },
                        new
                        {
                            UserId = new Guid("d9ba6ca2-e8ca-4444-8b1f-0d97ad04135a"),
                            RoleId = new Guid("df172293-c03c-462d-be88-ba9ad41c8cf7")
                        },
                        new
                        {
                            UserId = new Guid("8eb818e5-6a31-4710-9532-aebb2194776f"),
                            RoleId = new Guid("5ba00775-fb4a-49a9-a1c4-9c41fc2136dc")
                        },
                        new
                        {
                            UserId = new Guid("f6de83b9-76d9-4899-8a2c-f9bef0db8898"),
                            RoleId = new Guid("7056419c-e665-4a17-b88c-e5a41237e0fb")
                        },
                        new
                        {
                            UserId = new Guid("5ceffaa0-093f-4ce3-9a3d-0a8e6734b85e"),
                            RoleId = new Guid("7b68a169-3cf0-403d-a5b9-8bcf8319ca13")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.HasOne("Domain.Entities.User", "Customer")
                        .WithMany("CustomerOrders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "Сarrier")
                        .WithMany("CarrierOrders")
                        .HasForeignKey("СarrierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Сarrier");
                });

            modelBuilder.Entity("Domain.Entities.OrderProduct", b =>
                {
                    b.HasOne("Domain.Entities.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.OrderProduct", null)
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderProductId");

                    b.HasOne("Domain.Entities.ShopProduct", "ShopProduct")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ShopProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("ShopProduct");
                });

            modelBuilder.Entity("Domain.Entities.ShopLocation", b =>
                {
                    b.HasOne("Domain.Entities.Shop", "Shop")
                        .WithMany("Locations")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("Domain.Entities.ShopProduct", b =>
                {
                    b.HasOne("Domain.Entities.ProductDictionary", "Product")
                        .WithMany("ShopProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Shop", "Shop")
                        .WithMany("ShopProducts")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("Domain.Entities.UserShop", b =>
                {
                    b.HasOne("Domain.Entities.Shop", "Shop")
                        .WithMany("UserShops")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("UserShops")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("Domain.Entities.OrderProduct", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("Domain.Entities.ProductDictionary", b =>
                {
                    b.Navigation("ShopProducts");
                });

            modelBuilder.Entity("Domain.Entities.Shop", b =>
                {
                    b.Navigation("Locations");

                    b.Navigation("ShopProducts");

                    b.Navigation("UserShops");
                });

            modelBuilder.Entity("Domain.Entities.ShopProduct", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("CarrierOrders");

                    b.Navigation("CustomerOrders");

                    b.Navigation("UserShops");
                });
#pragma warning restore 612, 618
        }
    }
}
