﻿// <auto-generated />
using System;
using AhmadAghazadeh.Shop.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AhmadAghazadeh.Shop.Persistence.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20200726092346_FirstInit")]
    partial class FirstInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AhmadAghazadeh.Shop.CustomerContext.Domain.Customers.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<string>("AddressLine")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("CityId")
                        .HasColumnType("Int");

                    b.Property<string>("Coordinate")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<string>("PostalCode")
                        .HasColumnType("NChar(10)");

                    b.Property<string>("Telephone")
                        .HasColumnType("NChar(11)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Address","Shop");
                });

            modelBuilder.Entity("AhmadAghazadeh.Shop.CustomerContext.Domain.Customers.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("NationalCode")
                        .IsRequired()
                        .HasColumnType("NChar(10)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("Int");

                    b.HasKey("Id");

                    b.ToTable("Customer","Shop");
                });

            modelBuilder.Entity("AhmadAghazadeh.Shop.OrderContext.Domain.Orders.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<long>("Number")
                        .HasColumnType("BigInt");

                    b.Property<double>("ShippingCost")
                        .HasColumnType("Float");

                    b.Property<double>("Tax")
                        .HasColumnType("Float");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("Float");

                    b.HasKey("Id");

                    b.ToTable("Order","Shop");
                });

            modelBuilder.Entity("AhmadAghazadeh.Shop.OrderContext.Domain.Orders.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<double>("Price")
                        .HasColumnType("Float");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("Int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem","Shop");
                });

            modelBuilder.Entity("AhmadAghazadeh.Shop.CustomerContext.Domain.Customers.Address", b =>
                {
                    b.HasOne("AhmadAghazadeh.Shop.CustomerContext.Domain.Customers.Customer", "Customer")
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AhmadAghazadeh.Shop.OrderContext.Domain.Orders.OrderItem", b =>
                {
                    b.HasOne("AhmadAghazadeh.Shop.OrderContext.Domain.Orders.Order", "Order")
                        .WithMany("Cart")
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
