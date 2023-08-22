﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProdajaSlika.Models;

#nullable disable

namespace ProdajaSlika.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230821214733_addedIdentity")]
    partial class addedIdentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProdajaSlika.Models.CanvasType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CanvasTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Kinesko platno, manje izražena tekstura",
                            Name = "Tanje platno"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Nemačko platno, izraženija tekstura",
                            Name = "Deblje platno"
                        });
                });

            modelBuilder.Entity("ProdajaSlika.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Mnogo je zaljubljenika u Beograd i za to svakako postoji mnogo dobrih razloga. Ovo je odličan način da na zid prenesete neke od najlepših kadrova iz srpske prestonice, koji su zabeleženi objektivom fotoaparata.",
                            Name = "Slike Beograda"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Mnogo je zaljubljenika u našu zemlju Srbiju i za to svakako postoji mnogo dobrih razloga. Ovo je odličan način da na zid prenesete neke od najlepših kadrova iz države Srbije, koji su zabeleženi objektivom fotoaparata.",
                            Name = "Slike Srbije"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Unesite šarm svetskih metropola u svoj enterijer. Digitalna štampa na platnu je najbolji način da zidove ulepšate slikama gradova sveta. Ulice Pariza, Londona ili Njujorka mogu da budu pred vašim očima čak i onda kada vi niste na njima.",
                            Name = "Gradovi sveta"
                        },
                        new
                        {
                            Id = 4,
                            Description = "U vaš dom ili poslovni prostor unesite neverovatne kadrove kakve je moguće zabeležiti samo u prirodi. Prelepi predeli prirode nikoga ne ostavljaju ravnodušnim.",
                            Name = "Slike prirode"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Feng šui, što znači vetar i voda na kineskom jeziku, predstavlja drevnu kinesku praksu koja se bavi uređenjem prostora kako bi se postigla harmonija i balans između okoline i ljudske energije.",
                            Name = "Feng shui"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Crtež jeste baza svih vizelnih umetnosti, ali je crtež i sam po sebi jednako vredno umetničko delo. Velika imena u svetu umetnosti, iako često  upamćena po svojim slikama, iza sebe su ostavila i neke maestralne crteže. Ujedno, crteži su dokaz da umetničko delo sa jakom porukom može da bude stvoreno i na običnom parčetu hartije, uz pomoć grafitne olovke.",
                            Name = "Crtezi"
                        },
                        new
                        {
                            Id = 7,
                            Description = "U vaš dom ili poslovni prostor unesite neverovatne kadrove kakve je moguće zabeležiti samo u prirodi. Životinje vekovima privlače pažnju ljudi i zadivljuju svojim osobinama i izgledom.",
                            Name = "Posteri zivotinja"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Stare mape sveta su danas jedan od omiljenih načina za uređenje enterijera kod svih ljubitelja putovanja, istrorije ili avanture. Uglavnom se koristi za kafiće, restorane i hotele, ali nije mali broj pustolova-amatera koji ih imaju na zidovima svojih soba.",
                            Name = "Stare mape sveta"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Dekorativne slike vam omogućavaju da povoljno uredite bilo koju prostoriju ili čitav objekat tako da dobije upečatljiv umetnički efekat. Ovo može biti i lep poklon za vaše prijatelje i njihov dom.",
                            Name = "Dekorativne slike"
                        });
                });

            modelBuilder.Entity("ProdajaSlika.Models.FrameType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FrameTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Blind ram(2cm)"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Blind ram(3,5cm)"
                        });
                });

            modelBuilder.Entity("ProdajaSlika.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ProdajaSlika.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("PicId")
                        .HasColumnType("int");

                    b.Property<int>("PictureId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("PictureId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ProdajaSlika.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CanvasTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FrameTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSpecialOffer")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PictureHeight")
                        .HasColumnType("int");

                    b.Property<int>("PictureWidth")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CanvasTypeId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FrameTypeId");

                    b.ToTable("Pictures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CanvasTypeId = 1,
                            CategoryId = 1,
                            Description = "",
                            FrameTypeId = 1,
                            ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2020/09/092-Saborna-crkva.jpg",
                            IsSpecialOffer = false,
                            Name = "Saborna crkva",
                            PictureHeight = 60,
                            PictureWidth = 30,
                            Price = 1366m
                        },
                        new
                        {
                            Id = 2,
                            CanvasTypeId = 2,
                            CategoryId = 2,
                            Description = "",
                            FrameTypeId = 1,
                            ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2020/09/001-Goluba%C4%8Dka-tvr%C4%91ava.jpg",
                            IsSpecialOffer = false,
                            Name = "Golubačka tvrđava",
                            PictureHeight = 60,
                            PictureWidth = 60,
                            Price = 2670m
                        },
                        new
                        {
                            Id = 3,
                            CanvasTypeId = 1,
                            CategoryId = 3,
                            Description = "",
                            FrameTypeId = 1,
                            ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2014/12/001-Pariz-1.jpg",
                            IsSpecialOffer = true,
                            Name = "Pariz",
                            PictureHeight = 90,
                            PictureWidth = 90,
                            Price = 4627m
                        },
                        new
                        {
                            Id = 4,
                            CanvasTypeId = 1,
                            CategoryId = 5,
                            Description = "",
                            FrameTypeId = 2,
                            ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2016/03/01-feng-shui.jpg",
                            IsSpecialOffer = false,
                            Name = "Balans",
                            PictureHeight = 30,
                            PictureWidth = 30,
                            Price = 1283m
                        },
                        new
                        {
                            Id = 5,
                            CanvasTypeId = 2,
                            CategoryId = 4,
                            Description = "",
                            FrameTypeId = 1,
                            ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2020/09/PRI-001.jpg",
                            IsSpecialOffer = false,
                            Name = "Sunčana oluja",
                            PictureHeight = 55,
                            PictureWidth = 45,
                            Price = 2046m
                        },
                        new
                        {
                            Id = 6,
                            CanvasTypeId = 1,
                            CategoryId = 9,
                            Description = "",
                            FrameTypeId = 2,
                            ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2020/09/DEK-007.jpg",
                            IsSpecialOffer = false,
                            Name = "Love",
                            PictureHeight = 80,
                            PictureWidth = 20,
                            Price = 1811m
                        },
                        new
                        {
                            Id = 7,
                            CanvasTypeId = 1,
                            CategoryId = 8,
                            Description = "",
                            FrameTypeId = 1,
                            ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2014/12/Stara-mapa-sveta-8.jpg",
                            IsSpecialOffer = true,
                            Name = "Južna Amerika",
                            PictureHeight = 75,
                            PictureWidth = 35,
                            Price = 2089m
                        },
                        new
                        {
                            Id = 8,
                            CanvasTypeId = 2,
                            CategoryId = 7,
                            Description = "",
                            FrameTypeId = 2,
                            ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2014/12/Gepard-7.jpg",
                            IsSpecialOffer = false,
                            Name = "Gepard",
                            PictureHeight = 110,
                            PictureWidth = 50,
                            Price = 5053m
                        },
                        new
                        {
                            Id = 9,
                            CanvasTypeId = 1,
                            CategoryId = 6,
                            Description = "",
                            FrameTypeId = 2,
                            ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2014/12/Agnes-Denes-The-Human-Argument1.jpg",
                            IsSpecialOffer = false,
                            Name = "The Human Argument",
                            PictureHeight = 70,
                            PictureWidth = 45,
                            Price = 2827m
                        },
                        new
                        {
                            Id = 10,
                            CanvasTypeId = 2,
                            CategoryId = 5,
                            Description = "",
                            FrameTypeId = 1,
                            ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2016/03/11-feng-shui.jpg",
                            IsSpecialOffer = true,
                            Name = "Mirisna sveća",
                            PictureHeight = 95,
                            PictureWidth = 55,
                            Price = 4268m
                        });
                });

            modelBuilder.Entity("ProdajaSlika.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("PictureId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PictureId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProdajaSlika.Models.OrderDetail", b =>
                {
                    b.HasOne("ProdajaSlika.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProdajaSlika.Models.Picture", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Picture");
                });

            modelBuilder.Entity("ProdajaSlika.Models.Picture", b =>
                {
                    b.HasOne("ProdajaSlika.Models.CanvasType", "CanvasType")
                        .WithMany()
                        .HasForeignKey("CanvasTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProdajaSlika.Models.Category", "Category")
                        .WithMany("Pictures")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProdajaSlika.Models.FrameType", "FrameType")
                        .WithMany()
                        .HasForeignKey("FrameTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CanvasType");

                    b.Navigation("Category");

                    b.Navigation("FrameType");
                });

            modelBuilder.Entity("ProdajaSlika.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ProdajaSlika.Models.Picture", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Picture");
                });

            modelBuilder.Entity("ProdajaSlika.Models.Category", b =>
                {
                    b.Navigation("Pictures");
                });

            modelBuilder.Entity("ProdajaSlika.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
