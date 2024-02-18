﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Piligrimm.Server.Infrastructure;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(InfrastructureContext))]
    partial class InfrastructureContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Piligrimm.Server.Infrastructure.Models.Market.CategoryEntity", b =>
                {
                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("uid");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uuid")
                        .HasColumnName("parent_id");

                    b.HasKey("Uid")
                        .HasName("pk_categories");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Piligrimm.Server.Infrastructure.Models.Market.ProductEntity", b =>
                {
                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("uid");

                    b.Property<Guid>("CategoryUid")
                        .HasColumnType("uuid")
                        .HasColumnName("category_uid");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<double>("Discount")
                        .HasColumnType("double precision")
                        .HasColumnName("discount");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.HasKey("Uid")
                        .HasName("pk_products");

                    b.HasIndex("CategoryUid")
                        .HasDatabaseName("ix_products_category_uid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Piligrimm.Server.Infrastructure.Models.Market.ProductEntity", b =>
                {
                    b.HasOne("Piligrimm.Server.Infrastructure.Models.Market.CategoryEntity", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryUid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_products_categories_category_uid");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}