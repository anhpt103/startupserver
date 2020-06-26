﻿// <auto-generated />
using System;
using ATKSmartApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ATKSmartApi.Migrations
{
    [DbContext(typeof(ATKSmartContext))]
    [Migration("20200626061519_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ATKSmartApi.Entities.Auth.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("GroupId");

                    b.ToTable("TblGroup");
                });

            modelBuilder.Entity("ATKSmartApi.Entities.Auth.GroupMenu", b =>
                {
                    b.Property<string>("Menu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("Add")
                        .HasColumnType("bit");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit");

                    b.Property<bool>("Edit")
                        .HasColumnType("bit");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<bool>("View")
                        .HasColumnType("bit");

                    b.HasKey("Menu", "GroupId");

                    b.ToTable("TblGroupMenu");
                });

            modelBuilder.Entity("ATKSmartApi.Entities.Auth.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("StoreId");

                    b.ToTable("TblStore");
                });

            modelBuilder.Entity("ATKSmartApi.Entities.Auth.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Token")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("UserId");

                    b.ToTable("TblUser");
                });

            modelBuilder.Entity("ATKSmartApi.Entities.Auth.UserGroup", b =>
                {
                    b.Property<int>("UserGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserGroupId");

                    b.ToTable("TblUserGroup");
                });

            modelBuilder.Entity("ATKSmartApi.Entities.Auth.UserMenu", b =>
                {
                    b.Property<string>("Menu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("Add")
                        .HasColumnType("bit");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit");

                    b.Property<bool>("Edit")
                        .HasColumnType("bit");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<bool>("View")
                        .HasColumnType("bit");

                    b.HasKey("Menu", "UserId");

                    b.ToTable("TblUserMenu");
                });

            modelBuilder.Entity("ATKSmartApi.Entities.Auth.UserStore", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "StoreId");

                    b.ToTable("TblUserStore");
                });

            modelBuilder.Entity("ATKSmartApi.Entities.Categories.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5);

                    b.Property<decimal>("ProductInventory")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(100);

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int>("TaxId")
                        .HasColumnType("int");

                    b.Property<int?>("UnitCalcId")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.ToTable("TblProduct");
                });

            modelBuilder.Entity("ATKSmartApi.Entities.Categories.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("RoomPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RoomType")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RoomId");

                    b.ToTable("TblRoom");
                });

            modelBuilder.Entity("ATKSmartApi.Entities.Categories.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("CreateBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("UpdateBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SupplierId");

                    b.ToTable("TblSupplier");
                });

            modelBuilder.Entity("ATKSmartApi.Entities.Categories.Tax", b =>
                {
                    b.Property<int>("TaxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<string>("TaxName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("TaxValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TaxId");

                    b.ToTable("TblTax");
                });

            modelBuilder.Entity("ATKSmartApi.Entities.Categories.UnitCalc", b =>
                {
                    b.Property<int>("UnitCalcId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<string>("UnitCalcName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("UpdateBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UnitCalcId");

                    b.ToTable("TblUnitCalc");
                });
#pragma warning restore 612, 618
        }
    }
}
