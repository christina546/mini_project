﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniProject.Models;

namespace MiniProject.Migrations
{
    [DbContext(typeof(CarContext))]
    partial class CarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("MiniProject.Models.Car", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("bodyType")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("engine")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("make")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("numDoors")
                        .HasColumnType("bigint");

                    b.Property<int>("numWheels")
                        .HasColumnType("bigint");

                    b.Property<string>("vehicleType")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("id");

                    b.ToTable("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
