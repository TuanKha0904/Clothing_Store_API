﻿// <auto-generated />
using System;
using ClothingStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClothingStore.Data.ClothingStoreDB
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClothingStore.Models.Domain.Authorities", b =>
                {
                    b.Property<int>("ID_Authorize")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Authorize"), 1L, 1);

                    b.Property<string>("Authorize")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Authorize");

                    b.ToTable("Authorities");
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.Category", b =>
                {
                    b.Property<int>("ID_Category")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Category"), 1L, 1);

                    b.Property<string>("NameCategory")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Category");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.Manage_Image", b =>
                {
                    b.Property<int>("ID_MI")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_MI"), 1L, 1);

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image_url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_MI");

                    b.ToTable("Manage_Image");
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.Order", b =>
                {
                    b.Property<int>("ID_Order")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Order"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOrder")
                        .HasColumnType("datetime2");

                    b.Property<int>("ID_User")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Order");

                    b.HasIndex("ID_User");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.Order_Detail", b =>
                {
                    b.Property<int>("ID_Order_Detail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Order_Detail"), 1L, 1);

                    b.Property<int>("ID_Order")
                        .HasColumnType("int");

                    b.Property<int>("ID_Product")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID_Order_Detail");

                    b.HasIndex("ID_Order");

                    b.HasIndex("ID_Product");

                    b.ToTable("Order_Detail");
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.Product", b =>
                {
                    b.Property<int>("ID_Product")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Product"), 1L, 1);

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<int>("ID_Category")
                        .HasColumnType("int");

                    b.Property<int>("ID_MI")
                        .HasColumnType("int");

                    b.Property<string>("NameProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("ProductDetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Product");

                    b.HasIndex("ID_Category");

                    b.HasIndex("ID_MI");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.User", b =>
                {
                    b.Property<int>("ID_User")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_User"), 1L, 1);

                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ID_Authorize")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_User");

                    b.HasIndex("ID_Authorize");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityRole");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "2",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.Order", b =>
                {
                    b.HasOne("ClothingStore.Models.Domain.User", "user")
                        .WithMany("Order")
                        .HasForeignKey("ID_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.Order_Detail", b =>
                {
                    b.HasOne("ClothingStore.Models.Domain.Order", "Order")
                        .WithMany("Order_Details")
                        .HasForeignKey("ID_Order")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClothingStore.Models.Domain.Product", "Product")
                        .WithMany("Order_Details")
                        .HasForeignKey("ID_Product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.Product", b =>
                {
                    b.HasOne("ClothingStore.Models.Domain.Category", "Categories")
                        .WithMany("Product")
                        .HasForeignKey("ID_Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClothingStore.Models.Domain.Manage_Image", "Manage_Images")
                        .WithMany("Product")
                        .HasForeignKey("ID_MI")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Manage_Images");
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.User", b =>
                {
                    b.HasOne("ClothingStore.Models.Domain.Authorities", "Authorities")
                        .WithMany("User")
                        .HasForeignKey("ID_Authorize")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Authorities");
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.Authorities", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.Category", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.Manage_Image", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.Order", b =>
                {
                    b.Navigation("Order_Details");
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.Product", b =>
                {
                    b.Navigation("Order_Details");
                });

            modelBuilder.Entity("ClothingStore.Models.Domain.User", b =>
                {
                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
