﻿// <auto-generated />
using System;
using Kanoo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kanoo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231021184548_TestMigration")]
    partial class TestMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Kanoo.Models.Api", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("day")
                        .HasColumnType("int");

                    b.Property<string>("dayOfWeek")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("dstActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("hour")
                        .HasColumnType("int");

                    b.Property<int>("milliSeconds")
                        .HasColumnType("int");

                    b.Property<int>("minute")
                        .HasColumnType("int");

                    b.Property<int>("month")
                        .HasColumnType("int");

                    b.Property<int>("seconds")
                        .HasColumnType("int");

                    b.Property<string>("time")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("timeZone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Api");
                });

            modelBuilder.Entity("Kanoo.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Destination")
                        .HasColumnType("int");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("NumOfDrivers")
                        .HasColumnType("int");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TravelServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TravelServiceId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Kanoo.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("From")
                        .HasColumnType("int");

                    b.Property<DateTime>("Leave")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Return")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("To")
                        .HasColumnType("int");

                    b.Property<int>("TravelServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TravelServiceId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("Kanoo.Models.FlightAndHotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("From")
                        .HasColumnType("int");

                    b.Property<DateTime>("Leave")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Return")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("To")
                        .HasColumnType("int");

                    b.Property<int>("TravelServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TravelServiceId");

                    b.ToTable("FlightAndHotels");
                });

            modelBuilder.Entity("Kanoo.Models.Stay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Adults")
                        .HasColumnType("int");

                    b.Property<DateTime>("Arrive")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Children")
                        .HasColumnType("int");

                    b.Property<DateTime>("Depart")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Destination")
                        .HasColumnType("int");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.Property<int>("TravelServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TravelServiceId");

                    b.ToTable("Stays");
                });

            modelBuilder.Entity("Kanoo.Models.TravelService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TravelService");
                });

            modelBuilder.Entity("Kanoo.Models.Car", b =>
                {
                    b.HasOne("Kanoo.Models.TravelService", "Department")
                        .WithMany()
                        .HasForeignKey("TravelServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Kanoo.Models.Flight", b =>
                {
                    b.HasOne("Kanoo.Models.TravelService", "Department")
                        .WithMany("Flight")
                        .HasForeignKey("TravelServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Kanoo.Models.FlightAndHotel", b =>
                {
                    b.HasOne("Kanoo.Models.TravelService", "Department")
                        .WithMany()
                        .HasForeignKey("TravelServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Kanoo.Models.Stay", b =>
                {
                    b.HasOne("Kanoo.Models.TravelService", "Department")
                        .WithMany()
                        .HasForeignKey("TravelServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Kanoo.Models.TravelService", b =>
                {
                    b.Navigation("Flight");
                });
#pragma warning restore 612, 618
        }
    }
}