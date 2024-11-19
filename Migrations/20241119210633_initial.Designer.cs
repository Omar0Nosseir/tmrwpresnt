﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tmrwpresnt.Data;

#nullable disable

namespace tmrwpresnt.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241119210633_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductUser", b =>
                {
                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("ProductsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("ProductUser");
                });

            modelBuilder.Entity("tmrwpresnt.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("tmrwpresnt.Models.PaymentCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cardname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cardnumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Expiredate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("payemntcards");
                });

            modelBuilder.Entity("tmrwpresnt.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("categoryId")
                        .HasColumnType("int");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("categoryId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("tmrwpresnt.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.ToTable("users");
                });

            modelBuilder.Entity("ProductUser", b =>
                {
                    b.HasOne("tmrwpresnt.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tmrwpresnt.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmrwpresnt.Models.Product", b =>
                {
                    b.HasOne("tmrwpresnt.Models.Category", "category")
                        .WithMany("Products")
                        .HasForeignKey("categoryId");

                    b.Navigation("category");
                });

            modelBuilder.Entity("tmrwpresnt.Models.User", b =>
                {
                    b.HasOne("tmrwpresnt.Models.PaymentCard", "Card")
                        .WithOne("User")
                        .HasForeignKey("tmrwpresnt.Models.User", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");
                });

            modelBuilder.Entity("tmrwpresnt.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("tmrwpresnt.Models.PaymentCard", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
