﻿// <auto-generated />
using System;
using BankTransactions.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BankTransactions.Migrations
{
    [DbContext(typeof(GazlicecekDbContext))]
    [Migration("20221213152941_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BankTransactions.Models.Gazlicecek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Boyut")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Calories")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Carbohydrates")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("IcecekFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IcecekPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KYili")
                        .HasColumnType("datetime2");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Ozellik1")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Ozellik2")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Ozellik3")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Seker")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Tur")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Ulke")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Gazliceceks");
                });
#pragma warning restore 612, 618
        }
    }
}