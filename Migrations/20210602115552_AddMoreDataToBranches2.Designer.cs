﻿// <auto-generated />
using EFIntro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFIntro.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210602115552_AddMoreDataToBranches2")]
    partial class AddMoreDataToBranches2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EFIntro.Models.BranchModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Area")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Riyadh",
                            Area = "idk",
                            Name = "RH-321"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Jeddah",
                            Area = "idk",
                            Name = "JED-453"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Riyadh",
                            Area = "idk",
                            Name = "RH-332"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Jeddah",
                            Area = "idk",
                            Name = "JED-55"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Riyadh",
                            Area = "idk",
                            Name = "RH-55"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Qassim",
                            Area = "idk",
                            Name = "QA-55"
                        },
                        new
                        {
                            Id = 7,
                            Address = "Median",
                            Area = "idk",
                            Name = "MD-55"
                        },
                        new
                        {
                            Id = 8,
                            Address = "Makkah",
                            Area = "idk",
                            Name = "MK-55"
                        },
                        new
                        {
                            Id = 9,
                            Address = "Riyadh",
                            Area = "idk",
                            Name = "RH-55"
                        },
                        new
                        {
                            Id = 10,
                            Address = "Yunbu",
                            Area = "idk",
                            Name = "YU-55"
                        });
                });

            modelBuilder.Entity("EFIntro.Models.CustomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "efkdl@email.com",
                            FirstName = "ahmed",
                            LastName = "okdlkio"
                        },
                        new
                        {
                            Id = 2,
                            Email = "efkdl@email.com",
                            FirstName = "khalid",
                            LastName = "dfsfds"
                        },
                        new
                        {
                            Id = 3,
                            Email = "efkdl@email.com",
                            FirstName = "sara",
                            LastName = "sadsa"
                        },
                        new
                        {
                            Id = 4,
                            Email = "efkdl@email.com",
                            FirstName = "nora",
                            LastName = "fwerf"
                        });
                });

            modelBuilder.Entity("EFIntro.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
