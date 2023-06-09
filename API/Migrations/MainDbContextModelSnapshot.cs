﻿// <auto-generated />
using System;
using Colab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Colab.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("Colab.Models.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("state")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Assignments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 9, 24, 17, 27, 28, 532, DateTimeKind.Local).AddTicks(5243),
                            Description = "Voluptate consequatu",
                            ProjectId = 9,
                            Title = "Small Plastic Chair",
                            UpdatedAt = new DateTime(2023, 1, 30, 1, 37, 26, 884, DateTimeKind.Local).AddTicks(1147),
                            UserId = 2,
                            state = 2
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 11, 1, 15, 28, 43, 981, DateTimeKind.Local).AddTicks(7911),
                            Description = "Unde sit consequatur",
                            ProjectId = 9,
                            Title = "Ergonomic Granite Gloves",
                            UpdatedAt = new DateTime(2022, 11, 26, 21, 26, 53, 195, DateTimeKind.Local).AddTicks(7196),
                            UserId = 5,
                            state = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 9, 8, 19, 55, 50, 807, DateTimeKind.Local).AddTicks(2297),
                            Description = "Nihil error esse mod",
                            ProjectId = 7,
                            Title = "Sleek Frozen Soap",
                            UpdatedAt = new DateTime(2022, 5, 12, 0, 5, 8, 39, DateTimeKind.Local).AddTicks(8101),
                            UserId = 4,
                            state = 0
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 4, 8, 16, 12, 3, 96, DateTimeKind.Local).AddTicks(3400),
                            Description = "Autem itaque magni e",
                            ProjectId = 6,
                            Title = "Intelligent Rubber Shirt",
                            UpdatedAt = new DateTime(2022, 12, 24, 5, 0, 7, 337, DateTimeKind.Local).AddTicks(3055),
                            UserId = 1,
                            state = 2
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 3, 8, 3, 47, 50, 1, DateTimeKind.Local).AddTicks(4289),
                            Description = "Ut velit architecto ",
                            ProjectId = 3,
                            Title = "Awesome Frozen Chicken",
                            UpdatedAt = new DateTime(2023, 1, 15, 13, 54, 3, 907, DateTimeKind.Local).AddTicks(2507),
                            UserId = 5,
                            state = 0
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 10, 8, 9, 33, 26, 201, DateTimeKind.Local).AddTicks(8518),
                            Description = "Non mollitia exercit",
                            ProjectId = 4,
                            Title = "Practical Concrete Cheese",
                            UpdatedAt = new DateTime(2022, 5, 24, 13, 23, 17, 620, DateTimeKind.Local).AddTicks(8524),
                            UserId = 5,
                            state = 0
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 7, 20, 0, 26, 11, 349, DateTimeKind.Local).AddTicks(2371),
                            Description = "Sed qui optio iusto ",
                            ProjectId = 5,
                            Title = "Ergonomic Soft Pizza",
                            UpdatedAt = new DateTime(2022, 4, 11, 22, 51, 59, 262, DateTimeKind.Local).AddTicks(5924),
                            UserId = 1,
                            state = 1
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 6, 3, 18, 31, 21, 932, DateTimeKind.Local).AddTicks(1358),
                            Description = "Culpa veniam possimu",
                            ProjectId = 10,
                            Title = "Handcrafted Frozen Keyboard",
                            UpdatedAt = new DateTime(2022, 5, 4, 5, 54, 0, 368, DateTimeKind.Local).AddTicks(8235),
                            UserId = 2,
                            state = 1
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2023, 3, 2, 2, 18, 54, 233, DateTimeKind.Local).AddTicks(9933),
                            Description = "Repellat rerum quod ",
                            ProjectId = 4,
                            Title = "Ergonomic Cotton Ball",
                            UpdatedAt = new DateTime(2023, 3, 5, 0, 5, 51, 554, DateTimeKind.Local).AddTicks(3487),
                            UserId = 4,
                            state = 0
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 6, 22, 22, 26, 2, 827, DateTimeKind.Local).AddTicks(1651),
                            Description = "Rerum ipsam providen",
                            ProjectId = 1,
                            Title = "Ergonomic Rubber Bacon",
                            UpdatedAt = new DateTime(2023, 1, 25, 13, 50, 30, 50, DateTimeKind.Local).AddTicks(7723),
                            UserId = 3,
                            state = 1
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2022, 4, 9, 7, 20, 57, 122, DateTimeKind.Local).AddTicks(3494),
                            Description = "Reprehenderit velit ",
                            ProjectId = 10,
                            Title = "Gorgeous Fresh Salad",
                            UpdatedAt = new DateTime(2022, 5, 8, 22, 33, 44, 365, DateTimeKind.Local).AddTicks(2263),
                            UserId = 3,
                            state = 0
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2022, 12, 20, 1, 43, 17, 365, DateTimeKind.Local).AddTicks(6492),
                            Description = "Qui dignissimos quis",
                            ProjectId = 4,
                            Title = "Licensed Granite Towels",
                            UpdatedAt = new DateTime(2022, 7, 9, 14, 7, 52, 959, DateTimeKind.Local).AddTicks(8785),
                            UserId = 1,
                            state = 2
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2023, 3, 13, 7, 27, 46, 731, DateTimeKind.Local).AddTicks(3873),
                            Description = "Sint totam adipisci.",
                            ProjectId = 1,
                            Title = "Intelligent Metal Gloves",
                            UpdatedAt = new DateTime(2023, 2, 3, 8, 58, 34, 277, DateTimeKind.Local).AddTicks(5665),
                            UserId = 1,
                            state = 1
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2023, 1, 15, 20, 31, 32, 566, DateTimeKind.Local).AddTicks(1936),
                            Description = "Quia sequi molestiae",
                            ProjectId = 5,
                            Title = "Practical Frozen Shirt",
                            UpdatedAt = new DateTime(2023, 4, 4, 6, 57, 22, 117, DateTimeKind.Local).AddTicks(3640),
                            UserId = 3,
                            state = 0
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2022, 10, 5, 13, 15, 11, 468, DateTimeKind.Local).AddTicks(8903),
                            Description = "Laudantium debitis l",
                            ProjectId = 7,
                            Title = "Incredible Wooden Sausages",
                            UpdatedAt = new DateTime(2022, 11, 22, 22, 32, 14, 479, DateTimeKind.Local).AddTicks(9686),
                            UserId = 1,
                            state = 2
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateTime(2022, 8, 14, 21, 25, 14, 7, DateTimeKind.Local).AddTicks(8724),
                            Description = "Reprehenderit ut ita",
                            ProjectId = 6,
                            Title = "Licensed Concrete Bacon",
                            UpdatedAt = new DateTime(2022, 6, 21, 16, 5, 19, 180, DateTimeKind.Local).AddTicks(176),
                            UserId = 3,
                            state = 1
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateTime(2023, 3, 15, 22, 27, 46, 425, DateTimeKind.Local).AddTicks(5716),
                            Description = "Ad molestiae enim eo",
                            ProjectId = 4,
                            Title = "Practical Soft Salad",
                            UpdatedAt = new DateTime(2022, 4, 10, 1, 8, 4, 474, DateTimeKind.Local).AddTicks(2087),
                            UserId = 3,
                            state = 0
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateTime(2023, 2, 19, 0, 21, 41, 437, DateTimeKind.Local).AddTicks(4126),
                            Description = "Unde quo possimus mo",
                            ProjectId = 2,
                            Title = "Fantastic Soft Computer",
                            UpdatedAt = new DateTime(2022, 6, 14, 15, 10, 14, 312, DateTimeKind.Local).AddTicks(6104),
                            UserId = 1,
                            state = 2
                        },
                        new
                        {
                            Id = 19,
                            CreatedAt = new DateTime(2022, 6, 12, 16, 59, 59, 671, DateTimeKind.Local).AddTicks(8086),
                            Description = "Eius facilis ad nobi",
                            ProjectId = 1,
                            Title = "Incredible Metal Fish",
                            UpdatedAt = new DateTime(2022, 11, 24, 15, 11, 21, 855, DateTimeKind.Local).AddTicks(7518),
                            UserId = 5,
                            state = 2
                        },
                        new
                        {
                            Id = 20,
                            CreatedAt = new DateTime(2022, 8, 20, 4, 37, 17, 752, DateTimeKind.Local).AddTicks(9622),
                            Description = "Molestiae perspiciat",
                            ProjectId = 7,
                            Title = "Gorgeous Cotton Mouse",
                            UpdatedAt = new DateTime(2022, 10, 7, 12, 30, 7, 717, DateTimeKind.Local).AddTicks(6952),
                            UserId = 1,
                            state = 1
                        });
                });

            modelBuilder.Entity("Colab.Models.EmailVerifTokens", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("EmailVerifTokens");
                });

            modelBuilder.Entity("Colab.Models.PasswordResetTokens", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PasswordResetTokens");
                });

            modelBuilder.Entity("Colab.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 10, 13, 4, 38, 11, 872, DateTimeKind.Local).AddTicks(3153),
                            Description = "Itaque est inventore",
                            Title = "Awesome Plastic Cheese",
                            UpdatedAt = new DateTime(2022, 6, 19, 19, 30, 5, 609, DateTimeKind.Local).AddTicks(5345)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 4, 16, 14, 29, 42, 908, DateTimeKind.Local).AddTicks(882),
                            Description = "Sit sed dolorem recu",
                            Title = "Handmade Granite Chicken",
                            UpdatedAt = new DateTime(2022, 9, 4, 7, 28, 10, 134, DateTimeKind.Local).AddTicks(2653)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 5, 7, 3, 32, 30, 166, DateTimeKind.Local).AddTicks(2866),
                            Description = "Est perspiciatis qui",
                            Title = "Rustic Frozen Towels",
                            UpdatedAt = new DateTime(2022, 5, 28, 0, 53, 37, 902, DateTimeKind.Local).AddTicks(3984)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 3, 7, 6, 58, 55, 665, DateTimeKind.Local).AddTicks(7928),
                            Description = "Est est ducimus saep",
                            Title = "Intelligent Concrete Shoes",
                            UpdatedAt = new DateTime(2022, 11, 24, 18, 27, 35, 503, DateTimeKind.Local).AddTicks(3279)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 10, 19, 16, 17, 0, 120, DateTimeKind.Local).AddTicks(3939),
                            Description = "Architecto omnis nem",
                            Title = "Handcrafted Soft Cheese",
                            UpdatedAt = new DateTime(2023, 1, 18, 20, 1, 43, 550, DateTimeKind.Local).AddTicks(7401)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 5, 5, 8, 35, 4, 694, DateTimeKind.Local).AddTicks(3275),
                            Description = "Id officia dolorem i",
                            Title = "Tasty Frozen Chicken",
                            UpdatedAt = new DateTime(2022, 8, 27, 13, 37, 41, 224, DateTimeKind.Local).AddTicks(5152)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 12, 11, 0, 48, 10, 684, DateTimeKind.Local).AddTicks(2675),
                            Description = "Debitis dignissimos ",
                            Title = "Sleek Cotton Tuna",
                            UpdatedAt = new DateTime(2022, 6, 1, 0, 43, 19, 394, DateTimeKind.Local).AddTicks(7266)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 7, 7, 12, 21, 36, 124, DateTimeKind.Local).AddTicks(9738),
                            Description = "Et molestiae officia",
                            Title = "Unbranded Rubber Car",
                            UpdatedAt = new DateTime(2022, 9, 22, 4, 41, 29, 872, DateTimeKind.Local).AddTicks(1210)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 10, 11, 14, 59, 19, 47, DateTimeKind.Local).AddTicks(590),
                            Description = "Ut libero et sapient",
                            Title = "Handmade Plastic Bike",
                            UpdatedAt = new DateTime(2022, 11, 28, 11, 48, 26, 618, DateTimeKind.Local).AddTicks(6715)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2023, 1, 24, 22, 41, 33, 447, DateTimeKind.Local).AddTicks(4176),
                            Description = "Aliquid alias autem ",
                            Title = "Handmade Plastic Fish",
                            UpdatedAt = new DateTime(2022, 8, 30, 10, 45, 4, 270, DateTimeKind.Local).AddTicks(5894)
                        });
                });

            modelBuilder.Entity("Colab.Models.ProjectUser", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsOwner")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProjectId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ProjectUser");
                });

            modelBuilder.Entity("Colab.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("profilePicture")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Delphine_Stroman86@gmail.com",
                            IsAdmin = false,
                            IsVerified = false,
                            Name = "Joanne Ortiz",
                            Password = "$2a$11$WDRnnEeoGt/S569ZArapT.jpb.Vwwi13aS67vFct5mB2EEjXqACRK",
                            profilePicture = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/164.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Hyman.Kulas@hotmail.com",
                            IsAdmin = false,
                            IsVerified = false,
                            Name = "Rahul Hodkiewicz",
                            Password = "$2a$11$GOltA.d/bE2qOerTXGIxVeKhX.ElZlrMCGT6LrQ0gLFzczysYwN/i",
                            profilePicture = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/498.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Modesto_Williamson61@hotmail.com",
                            IsAdmin = false,
                            IsVerified = false,
                            Name = "Brent Weber",
                            Password = "$2a$11$4Fcw33d5ruCwjlEMZOj95eFvcqL1Tumh/lW3YbJw/Pu6.QC2LWJGO",
                            profilePicture = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/104.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Email = "Sallie.Brown@hotmail.com",
                            IsAdmin = false,
                            IsVerified = false,
                            Name = "Maxwell Rogahn",
                            Password = "$2a$11$bnQERpVaO3aLxiMDPUnerO49jF4IgqyhIqI9X7MfCU2NqfyCyYzJ.",
                            profilePicture = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1120.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Email = "Shawn9@gmail.com",
                            IsAdmin = false,
                            IsVerified = false,
                            Name = "Georgiana Bode",
                            Password = "$2a$11$4Y9VL0TF0gs1o3JK1GYjue/0GQ8QoDS3Nl0ppHIK4XZo1teucMp4.",
                            profilePicture = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1114.jpg"
                        });
                });

            modelBuilder.Entity("Colab.Models.Assignment", b =>
                {
                    b.HasOne("Colab.Models.Project", "Project")
                        .WithMany("Assignments")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Colab.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Colab.Models.EmailVerifTokens", b =>
                {
                    b.HasOne("Colab.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Colab.Models.PasswordResetTokens", b =>
                {
                    b.HasOne("Colab.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Colab.Models.ProjectUser", b =>
                {
                    b.HasOne("Colab.Models.Project", "Project")
                        .WithMany("Participators")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Colab.Models.User", "User")
                        .WithMany("Participations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Colab.Models.Project", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("Participators");
                });

            modelBuilder.Entity("Colab.Models.User", b =>
                {
                    b.Navigation("Participations");
                });
#pragma warning restore 612, 618
        }
    }
}
