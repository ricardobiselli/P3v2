﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240623163157_reducedClientAttributes")]
    partial class reducedClientAttributes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("CartProduct", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CartId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartProduct", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Products.Compatibility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GpuType")
                        .HasColumnType("TEXT");

                    b.Property<string>("PowerSupplyType")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RamType")
                        .HasColumnType("TEXT");

                    b.Property<string>("SocketType")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Compatibilities");
                });

            modelBuilder.Entity("Domain.Models.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PowerConsumption")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Domain.Models.Purchases.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderId");

                    b.HasIndex("ClientId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Domain.Models.Purchases.Payment", b =>
                {
                    b.Property<int?>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PaymentStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("PaymentId");

                    b.HasIndex("ClientId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Domain.Models.Purchases.ShoppingCart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CartId");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Domain.Models.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserType")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProduct", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Users.Admin", b =>
                {
                    b.HasBaseType("Domain.Models.Users.User");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("Domain.Models.Users.Client", b =>
                {
                    b.HasBaseType("Domain.Models.Users.User");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("DniNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("Domain.Models.Users.SuperAdmin", b =>
                {
                    b.HasBaseType("Domain.Models.Users.Admin");

                    b.HasDiscriminator().HasValue("SuperAdmin");
                });

            modelBuilder.Entity("CartProduct", b =>
                {
                    b.HasOne("Domain.Models.Purchases.ShoppingCart", null)
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Products.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Products.Compatibility", b =>
                {
                    b.HasOne("Domain.Models.Products.Product", "Product")
                        .WithOne("Compatibilities")
                        .HasForeignKey("Domain.Models.Products.Compatibility", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Domain.Models.Purchases.Order", b =>
                {
                    b.HasOne("Domain.Models.Users.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Domain.Models.Purchases.Payment", b =>
                {
                    b.HasOne("Domain.Models.Users.Client", "Client")
                        .WithMany("Payments")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Domain.Models.Purchases.ShoppingCart", b =>
                {
                    b.HasOne("Domain.Models.Users.Client", "Client")
                        .WithOne("Cart")
                        .HasForeignKey("Domain.Models.Purchases.ShoppingCart", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("Domain.Models.Purchases.Order", null)
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Products.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Products.Product", b =>
                {
                    b.Navigation("Compatibilities");
                });

            modelBuilder.Entity("Domain.Models.Users.Client", b =>
                {
                    b.Navigation("Cart");

                    b.Navigation("Orders");

                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
