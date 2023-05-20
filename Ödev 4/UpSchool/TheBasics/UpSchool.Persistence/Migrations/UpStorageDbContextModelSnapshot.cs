﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UpSchool.Persistence.EntityFramework.Contexts;

#nullable disable

namespace UpSchool.Persistence.Migrations
{
    [DbContext(typeof(UpStorageDbContext))]
    partial class UpStorageDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UpSchool.Domain.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Url")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Title", "UserName");

                    b.ToTable("Accounts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a122163c-b2bc-4068-93de-58c8a1122d88"),
                            CreatedOn = new DateTimeOffset(new DateTime(2023, 3, 21, 20, 43, 17, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            IsFavorite = true,
                            Password = "MTIzZ29vZ2xlMTIz",
                            Title = "Google",
                            Url = "",
                            UserName = "google_user"
                        },
                        new
                        {
                            Id = new Guid("93462dcf-f009-458c-9dce-c813ac2de2ca"),
                            CreatedOn = new DateTimeOffset(new DateTime(2023, 3, 21, 21, 43, 17, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            IsFavorite = true,
                            Password = "MTIzZmFjZWJvb2sxMjM=",
                            Title = "Facebook",
                            Url = "",
                            UserName = "facebook_user"
                        },
                        new
                        {
                            Id = new Guid("30d43e66-a177-4d6d-9644-5b9425a83aaf"),
                            CreatedOn = new DateTimeOffset(new DateTime(2023, 3, 21, 22, 43, 17, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            IsFavorite = true,
                            Password = "MTIzdGlrdG9rMTIz",
                            Title = "Tiktok",
                            Url = "",
                            UserName = "tiktok_user"
                        },
                        new
                        {
                            Id = new Guid("38576d84-cef2-4285-b8aa-a375f6bce7c3"),
                            CreatedOn = new DateTimeOffset(new DateTime(2023, 3, 21, 23, 43, 17, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            IsFavorite = true,
                            Password = "MTIzaW5zdGFncmFtMTIz",
                            Title = "Instagram",
                            Url = "",
                            UserName = "instagram_user"
                        },
                        new
                        {
                            Id = new Guid("fa588f1f-b4b0-4330-978c-bd0da99a6567"),
                            CreatedOn = new DateTimeOffset(new DateTime(2023, 3, 22, 0, 43, 17, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            IsFavorite = true,
                            Password = "MTIzdHdpdHRlcjEyMw==",
                            Title = "Twitter",
                            Url = "",
                            UserName = "twitter_user"
                        },
                        new
                        {
                            Id = new Guid("c4d97d5c-4309-4acc-b4b3-078ceffcea4c"),
                            CreatedOn = new DateTimeOffset(new DateTime(2023, 3, 22, 1, 43, 17, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            IsFavorite = true,
                            Password = "MTIzdHJlbmR5b2wxMjM=",
                            Title = "Trendyol",
                            Url = "",
                            UserName = "trendyol_user"
                        },
                        new
                        {
                            Id = new Guid("24af79f6-d586-419e-a684-143de39098e1"),
                            CreatedOn = new DateTimeOffset(new DateTime(2023, 3, 22, 2, 43, 17, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            IsFavorite = true,
                            Password = "MTIzdWRlbXkyMw==",
                            Title = "Udemy",
                            Url = "",
                            UserName = "udemy_user"
                        },
                        new
                        {
                            Id = new Guid("6320cdfc-6e37-4f7b-b8af-0d8c60922994"),
                            CreatedOn = new DateTimeOffset(new DateTime(2023, 3, 21, 3, 43, 17, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            IsFavorite = true,
                            Password = "MTIzZ2V0aXIxMjM==",
                            Title = "Getir",
                            Url = "",
                            UserName = "getir_user"
                        },
                        new
                        {
                            Id = new Guid("c6c5378a-b759-4034-984f-7ec58628c3f7"),
                            CreatedOn = new DateTimeOffset(new DateTime(2023, 3, 21, 4, 43, 17, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            IsFavorite = true,
                            Password = "MTIzaGVwc2lidXJhZGExMjM=",
                            Title = "Hepsiburada",
                            Url = "",
                            UserName = "hepsiburada_user"
                        },
                        new
                        {
                            Id = new Guid("c2b18a4f-7d5e-4696-932b-6797b7f4d661"),
                            CreatedOn = new DateTimeOffset(new DateTime(2023, 3, 21, 5, 43, 17, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            IsFavorite = true,
                            Password = "MTIzY291cnNlcmExMjM=",
                            Title = "Coursera",
                            Url = "",
                            UserName = "coursera_user"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
