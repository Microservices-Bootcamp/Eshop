﻿// <auto-generated />
using System;
using Catalog.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Catalog.Migrations
{
    [DbContext(typeof(EshopDatabase))]
    [Migration("20230614073459_table_name_changes")]
    partial class table_name_changes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Eshop_Db")
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Catalog.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories", "Eshop_Db");
                });

            modelBuilder.Entity("Catalog.Entities.Product", b =>
                {
                    b.Property<string>("Sku")
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("CostPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("SellingPrice")
                        .HasColumnType("numeric");

                    b.HasKey("Sku");

                    b.ToTable("Products", "Eshop_Db");
                });
#pragma warning restore 612, 618
        }
    }
}
