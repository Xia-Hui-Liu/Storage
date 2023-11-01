﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Storage.Data;

#nullable disable

namespace Storage.Migrations
{
    [DbContext(typeof(StorageContext))]
    partial class StorageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Storage.Models.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Shelf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 0,
                            Count = 30,
                            Description = "Latest iPhone model",
                            Name = "iPhone 13",
                            OrderDate = new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 999,
                            Shelf = "A1"
                        },
                        new
                        {
                            Id = 2,
                            Category = 0,
                            Count = 20,
                            Description = "Flagship Android phone",
                            Name = "Samsung Galaxy S21",
                            OrderDate = new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 899,
                            Shelf = "A2"
                        },
                        new
                        {
                            Id = 3,
                            Category = 0,
                            Count = 10,
                            Description = "Next-gen gaming console",
                            Name = "Sony PlayStation 5",
                            OrderDate = new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 499,
                            Shelf = "B1"
                        },
                        new
                        {
                            Id = 4,
                            Category = 1,
                            Count = 25,
                            Description = "Classic sneakers",
                            Name = "Nike Air Max 90",
                            OrderDate = new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 120,
                            Shelf = "B2"
                        },
                        new
                        {
                            Id = 5,
                            Category = 2,
                            Count = 100,
                            Description = "Fresh, organic apples",
                            Name = "Organic Apples",
                            OrderDate = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 3,
                            Shelf = "C3"
                        },
                        new
                        {
                            Id = 6,
                            Category = 0,
                            Count = 15,
                            Description = "Mid-range laptop",
                            Name = "HP Pavilion Laptop",
                            OrderDate = new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 799,
                            Shelf = "C4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
