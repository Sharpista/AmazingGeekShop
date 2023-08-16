﻿// <auto-generated />
using System;
using AmazingGeekShop.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AmazingGeekShop.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AmazingGeekShop.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("product_category_name");

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("product_description");

                    b.Property<string>("ImageURL")
                        .HasColumnType("longtext")
                        .HasColumnName("product_image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("product_name");

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("product_price");

                    b.HasKey("Id");

                    b.ToTable("product");
                });
#pragma warning restore 612, 618
        }
    }
}