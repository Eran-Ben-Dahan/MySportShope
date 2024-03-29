﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySportShope.API.Context;

#nullable disable

namespace MySportShope.API.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20230819170500_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ColorProduct", b =>
                {
                    b.Property<int>("ColorsID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("ColorsID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("ColorProduct");

                    b.HasData(
                        new
                        {
                            ColorsID = 1,
                            ProductID = 1
                        },
                        new
                        {
                            ColorsID = 2,
                            ProductID = 1
                        });
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.BoxSize", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.ToTable("BoxSizes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Height = 2.5,
                            Length = 10.0,
                            ProductID = 1,
                            Weight = 5.0,
                            Width = 5.0
                        },
                        new
                        {
                            ID = 2,
                            Height = 3.0,
                            Length = 8.0,
                            ProductID = 2,
                            Weight = 3.0,
                            Width = 4.0
                        },
                        new
                        {
                            ID = 3,
                            Height = 1.0,
                            Length = 10.0,
                            ProductID = 3,
                            Weight = 5.0,
                            Width = 9.0
                        });
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersoneTypeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Shoes",
                            PersoneTypeID = 1
                        },
                        new
                        {
                            ID = 2,
                            Name = "Sportswear",
                            PersoneTypeID = 1
                        });
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("BDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BDay = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "eran0099@gmail.com",
                            FirstName = "Eran",
                            LastName = "Ben Dahan",
                            PhoneNumber = 548050910
                        });
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.Color", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Red"
                        },
                        new
                        {
                            ID = 2,
                            Name = "yellow"
                        });
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Alt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Alt = "Black Sport Shoes ",
                            Description = "A beautiful and comfortable shoe",
                            Name = "Sport Shoes ",
                            ProductID = 1,
                            Title = "Shoes",
                            URL = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/88c3280a-1b77-4cf9-957f-d71b91e90393/revolution-6-road-running-shoes-sP4fgd.png"
                        });
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.ItemSize", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("SizeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ProductID = 1,
                            SizeName = "49"
                        });
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.OrderItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("OrdersID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OrdersID");

                    b.HasIndex("productID");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            OrdersID = 1,
                            Price = 25.5,
                            Quantity = 2,
                            productID = 1
                        },
                        new
                        {
                            ID = 2,
                            OrdersID = 1,
                            Price = 25.5,
                            Quantity = 2,
                            productID = 2
                        },
                        new
                        {
                            ID = 3,
                            OrdersID = 2,
                            Price = 25.5,
                            Quantity = 2,
                            productID = 2
                        });
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.Orders", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentID")
                        .HasColumnType("int");

                    b.Property<int>("ShippingAddresID")
                        .HasColumnType("int");

                    b.Property<int>("SpecialDiscount")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.ToTable("Orderss");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ClientID = 1,
                            OrderDate = new DateTime(2023, 8, 19, 20, 4, 59, 886, DateTimeKind.Local).AddTicks(4095),
                            PaymentID = 1,
                            ShippingAddresID = 1,
                            SpecialDiscount = 0
                        },
                        new
                        {
                            ID = 2,
                            ClientID = 1,
                            OrderDate = new DateTime(2023, 8, 19, 20, 4, 59, 886, DateTimeKind.Local).AddTicks(4108),
                            PaymentID = 1,
                            ShippingAddresID = 1,
                            SpecialDiscount = 0
                        });
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.Payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CardCvv")
                        .HasColumnType("int");

                    b.Property<int>("CardMonth")
                        .HasColumnType("int");

                    b.Property<int>("CardNumber")
                        .HasColumnType("int");

                    b.Property<int>("CardYear")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CardCvv = 123,
                            CardMonth = 2,
                            CardNumber = 134456775,
                            CardYear = 2024,
                            PaymentDate = new DateTime(2023, 8, 19, 20, 4, 59, 886, DateTimeKind.Local).AddTicks(4122)
                        });
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.PersoneType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PersoneTypes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Men"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Women"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Kids"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Men & Women"
                        });
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersoneTypeID")
                        .HasColumnType("int");

                    b.Property<int>("SubCategoryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PersoneTypeID");

                    b.HasIndex("SubCategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "A beautiful and comfortable shoe",
                            Manufacturer = "Nike",
                            Name = "Sport Shoes ",
                            PersoneTypeID = 1,
                            SubCategoryID = 1
                        },
                        new
                        {
                            ID = 2,
                            Description = "Butebull Tshert",
                            Manufacturer = "Nike",
                            Name = "Sport Tshert ",
                            PersoneTypeID = 1,
                            SubCategoryID = 1
                        },
                        new
                        {
                            ID = 3,
                            Description = "Ball",
                            Manufacturer = "Nike",
                            Name = "Ball ",
                            PersoneTypeID = 1,
                            SubCategoryID = 1
                        });
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.ShippingAddres", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Building")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("House")
                        .HasColumnType("int");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ShippingAddres");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Building = 13,
                            City = "Netanya",
                            Country = "Israel",
                            House = 5,
                            StreetName = "Rotem",
                            Zip = 5677
                        });
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.SubCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("SubCategorys");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            Name = "Running shoes"
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 1,
                            Name = "Basketball shoes"
                        });
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ClientID = 0,
                            LastLogin = new DateTime(2023, 8, 19, 20, 4, 59, 885, DateTimeKind.Local).AddTicks(3418),
                            Password = "1234",
                            Type = 999,
                            Username = "Eran"
                        });
                });

            modelBuilder.Entity("ColorProduct", b =>
                {
                    b.HasOne("MySportShope.API.Models.DTO.Color", null)
                        .WithMany()
                        .HasForeignKey("ColorsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MySportShope.API.Models.DTO.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.BoxSize", b =>
                {
                    b.HasOne("MySportShope.API.Models.DTO.Product", null)
                        .WithMany("BoxSizes")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.Image", b =>
                {
                    b.HasOne("MySportShope.API.Models.DTO.Product", null)
                        .WithMany("Images")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.ItemSize", b =>
                {
                    b.HasOne("MySportShope.API.Models.DTO.Product", null)
                        .WithMany("ItemSizes")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.OrderItem", b =>
                {
                    b.HasOne("MySportShope.API.Models.DTO.Orders", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrdersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MySportShope.API.Models.DTO.Product", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.Orders", b =>
                {
                    b.HasOne("MySportShope.API.Models.DTO.Client", null)
                        .WithMany("Orders")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.Product", b =>
                {
                    b.HasOne("MySportShope.API.Models.DTO.PersoneType", null)
                        .WithMany("Products")
                        .HasForeignKey("PersoneTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MySportShope.API.Models.DTO.SubCategory", null)
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.SubCategory", b =>
                {
                    b.HasOne("MySportShope.API.Models.DTO.Category", null)
                        .WithMany("SubCategorys")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.Category", b =>
                {
                    b.Navigation("SubCategorys");
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.Client", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.Orders", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.PersoneType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.Product", b =>
                {
                    b.Navigation("BoxSizes");

                    b.Navigation("Images");

                    b.Navigation("ItemSizes");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("MySportShope.API.Models.DTO.SubCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
