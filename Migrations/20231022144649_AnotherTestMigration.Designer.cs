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
    [Migration("20231022144649_AnotherTestMigration")]
    partial class AnotherTestMigration
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

            modelBuilder.Entity("Kanoo.Models.Contact", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DetailsV2id")
                        .HasColumnType("int");

                    b.Property<int>("TravelAdvisorId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("DetailsV2id");

                    b.HasIndex("TravelAdvisorId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Kanoo.Models.Data", b =>
                {
                    b.Property<int>("DataId")
                        .HasColumnType("int");

                    b.HasKey("DataId");

                    b.ToTable("Data");
                });

            modelBuilder.Entity("Kanoo.Models.Details", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("TravelAdvisorId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("TravelAdvisorId");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("Kanoo.Models.DetailsV2", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("TravelAdvisorId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.Property<bool?>("isGeo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("locationId")
                        .HasColumnType("int");

                    b.Property<string>("placeType")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("TravelAdvisorId");

                    b.ToTable("DetailsV2");
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

            modelBuilder.Entity("Kanoo.Models.Geocode", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DetailsV2id")
                        .HasColumnType("int");

                    b.Property<int>("TravelAdvisorId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.Property<double?>("latitude")
                        .HasColumnType("double");

                    b.Property<double?>("longitude")
                        .HasColumnType("double");

                    b.HasKey("id");

                    b.HasIndex("DetailsV2id");

                    b.HasIndex("TravelAdvisorId");

                    b.ToTable("Geocode");
                });

            modelBuilder.Entity("Kanoo.Models.Image", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("TravelAdvisorId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("TravelAdvisorId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Kanoo.Models.Names", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DetailsV2id")
                        .HasColumnType("int");

                    b.Property<int?>("ParentGeoDetailsid")
                        .HasColumnType("int");

                    b.Property<int>("TravelAdvisorId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.Property<string>("longOnlyHierarchyTypeaheadV2")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("DetailsV2id");

                    b.HasIndex("ParentGeoDetailsid");

                    b.HasIndex("TravelAdvisorId");

                    b.ToTable("Names");
                });

            modelBuilder.Entity("Kanoo.Models.ParentGeoDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("TravelAdvisorId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("TravelAdvisorId");

                    b.ToTable("ParentGeoDetails");
                });

            modelBuilder.Entity("Kanoo.Models.Photo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Imageid")
                        .HasColumnType("int");

                    b.Property<int>("TravelAdvisorId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("Imageid");

                    b.HasIndex("TravelAdvisorId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("Kanoo.Models.PhotoSize", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Photoid")
                        .HasColumnType("int");

                    b.Property<int>("TravelAdvisorId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.Property<int?>("height")
                        .HasColumnType("int");

                    b.Property<string>("url")
                        .HasColumnType("longtext");

                    b.Property<int?>("width")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Photoid");

                    b.HasIndex("TravelAdvisorId");

                    b.ToTable("PhotoSize");
                });

            modelBuilder.Entity("Kanoo.Models.PhotoSizeDynamic", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Photoid")
                        .HasColumnType("int");

                    b.Property<int>("TravelAdvisorId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.Property<int?>("maxHeight")
                        .HasColumnType("int");

                    b.Property<int?>("maxWidth")
                        .HasColumnType("int");

                    b.Property<string>("urlTemplate")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("Photoid");

                    b.HasIndex("TravelAdvisorId");

                    b.ToTable("PhotoSizeDynamic");
                });

            modelBuilder.Entity("Kanoo.Models.Root", b =>
                {
                    b.Property<int>("RootId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("RootId");

                    b.ToTable("Root");
                });

            modelBuilder.Entity("Kanoo.Models.Route", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DetailsV2id")
                        .HasColumnType("int");

                    b.Property<int>("TravelAdvisorId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.Property<string>("fragment")
                        .HasColumnType("longtext");

                    b.Property<string>("nonCanonicalUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("page")
                        .HasColumnType("longtext");

                    b.Property<string>("url")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("DetailsV2id");

                    b.HasIndex("TravelAdvisorId");

                    b.ToTable("Route");
                });

            modelBuilder.Entity("Kanoo.Models.SocialStatistics", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Detailsid")
                        .HasColumnType("int");

                    b.Property<int>("TravelAdvisorId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.Property<bool?>("isSaved")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("id");

                    b.HasIndex("Detailsid");

                    b.HasIndex("TravelAdvisorId");

                    b.ToTable("SocialStatistics");
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

            modelBuilder.Entity("Kanoo.Models.StreetAddress", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Contactid")
                        .HasColumnType("int");

                    b.Property<int>("TravelAdvisorId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.Property<string>("street1")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("Contactid");

                    b.HasIndex("TravelAdvisorId");

                    b.ToTable("StreetAddress");
                });

            modelBuilder.Entity("Kanoo.Models.TravelAdvisor", b =>
                {
                    b.Property<int>("TravelAdvisorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("TypeaheadAutocompleteId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.Property<string>("buCategory")
                        .HasColumnType("longtext");

                    b.Property<string>("documentId")
                        .HasColumnType("longtext");

                    b.Property<string>("scopeType")
                        .HasColumnType("longtext");

                    b.Property<string>("suggestionType")
                        .HasColumnType("longtext");

                    b.Property<string>("text")
                        .HasColumnType("longtext");

                    b.HasKey("TravelAdvisorId");

                    b.HasIndex("TypeaheadAutocompleteId");

                    b.ToTable("TravelAdvisor");
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

            modelBuilder.Entity("Kanoo.Models.TypeaheadAutocomplete", b =>
                {
                    b.Property<int>("TypeaheadAutocompleteId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.Property<string>("resultsId")
                        .HasColumnType("longtext");

                    b.HasKey("TypeaheadAutocompleteId");

                    b.ToTable("TypeaheadAutocomplete");
                });

            modelBuilder.Entity("Kanoo.Models.TypedParams", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Routeid")
                        .HasColumnType("int");

                    b.Property<int>("TravelAdvisorId")
                        .HasColumnType("int");

                    b.Property<string>("__typename")
                        .HasColumnType("longtext");

                    b.Property<int?>("geoId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Routeid");

                    b.HasIndex("TravelAdvisorId");

                    b.ToTable("TypedParams");
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

            modelBuilder.Entity("Kanoo.Models.Contact", b =>
                {
                    b.HasOne("Kanoo.Models.DetailsV2", null)
                        .WithMany("contact")
                        .HasForeignKey("DetailsV2id");

                    b.HasOne("Kanoo.Models.TravelAdvisor", "TravelAdvisor")
                        .WithMany()
                        .HasForeignKey("TravelAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelAdvisor");
                });

            modelBuilder.Entity("Kanoo.Models.Data", b =>
                {
                    b.HasOne("Kanoo.Models.Root", "Root")
                        .WithMany("Data")
                        .HasForeignKey("DataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Root");
                });

            modelBuilder.Entity("Kanoo.Models.Details", b =>
                {
                    b.HasOne("Kanoo.Models.TravelAdvisor", "TravelAdvisor")
                        .WithMany("details")
                        .HasForeignKey("TravelAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelAdvisor");
                });

            modelBuilder.Entity("Kanoo.Models.DetailsV2", b =>
                {
                    b.HasOne("Kanoo.Models.TravelAdvisor", "TravelAdvisor")
                        .WithMany("detailsV2")
                        .HasForeignKey("TravelAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelAdvisor");
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

            modelBuilder.Entity("Kanoo.Models.Geocode", b =>
                {
                    b.HasOne("Kanoo.Models.DetailsV2", null)
                        .WithMany("geocode")
                        .HasForeignKey("DetailsV2id");

                    b.HasOne("Kanoo.Models.TravelAdvisor", "TravelAdvisor")
                        .WithMany()
                        .HasForeignKey("TravelAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelAdvisor");
                });

            modelBuilder.Entity("Kanoo.Models.Image", b =>
                {
                    b.HasOne("Kanoo.Models.TravelAdvisor", "TravelAdvisor")
                        .WithMany("image")
                        .HasForeignKey("TravelAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelAdvisor");
                });

            modelBuilder.Entity("Kanoo.Models.Names", b =>
                {
                    b.HasOne("Kanoo.Models.DetailsV2", null)
                        .WithMany("names")
                        .HasForeignKey("DetailsV2id");

                    b.HasOne("Kanoo.Models.ParentGeoDetails", null)
                        .WithMany("names")
                        .HasForeignKey("ParentGeoDetailsid");

                    b.HasOne("Kanoo.Models.TravelAdvisor", "TravelAdvisor")
                        .WithMany()
                        .HasForeignKey("TravelAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelAdvisor");
                });

            modelBuilder.Entity("Kanoo.Models.ParentGeoDetails", b =>
                {
                    b.HasOne("Kanoo.Models.TravelAdvisor", "TravelAdvisor")
                        .WithMany("parentGeoDetails")
                        .HasForeignKey("TravelAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelAdvisor");
                });

            modelBuilder.Entity("Kanoo.Models.Photo", b =>
                {
                    b.HasOne("Kanoo.Models.Image", null)
                        .WithMany("photo")
                        .HasForeignKey("Imageid");

                    b.HasOne("Kanoo.Models.TravelAdvisor", "TravelAdvisor")
                        .WithMany()
                        .HasForeignKey("TravelAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelAdvisor");
                });

            modelBuilder.Entity("Kanoo.Models.PhotoSize", b =>
                {
                    b.HasOne("Kanoo.Models.Photo", null)
                        .WithMany("photoSizes")
                        .HasForeignKey("Photoid");

                    b.HasOne("Kanoo.Models.TravelAdvisor", "TravelAdvisor")
                        .WithMany()
                        .HasForeignKey("TravelAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelAdvisor");
                });

            modelBuilder.Entity("Kanoo.Models.PhotoSizeDynamic", b =>
                {
                    b.HasOne("Kanoo.Models.Photo", null)
                        .WithMany("photoSizeDynamic")
                        .HasForeignKey("Photoid");

                    b.HasOne("Kanoo.Models.TravelAdvisor", "TravelAdvisor")
                        .WithMany()
                        .HasForeignKey("TravelAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelAdvisor");
                });

            modelBuilder.Entity("Kanoo.Models.Route", b =>
                {
                    b.HasOne("Kanoo.Models.DetailsV2", null)
                        .WithMany("route")
                        .HasForeignKey("DetailsV2id");

                    b.HasOne("Kanoo.Models.TravelAdvisor", "TravelAdvisor")
                        .WithMany("route")
                        .HasForeignKey("TravelAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelAdvisor");
                });

            modelBuilder.Entity("Kanoo.Models.SocialStatistics", b =>
                {
                    b.HasOne("Kanoo.Models.Details", null)
                        .WithMany("socialStatistics")
                        .HasForeignKey("Detailsid");

                    b.HasOne("Kanoo.Models.TravelAdvisor", "TravelAdvisor")
                        .WithMany()
                        .HasForeignKey("TravelAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelAdvisor");
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

            modelBuilder.Entity("Kanoo.Models.StreetAddress", b =>
                {
                    b.HasOne("Kanoo.Models.Contact", null)
                        .WithMany("streetAddress")
                        .HasForeignKey("Contactid");

                    b.HasOne("Kanoo.Models.TravelAdvisor", "TravelAdvisor")
                        .WithMany()
                        .HasForeignKey("TravelAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelAdvisor");
                });

            modelBuilder.Entity("Kanoo.Models.TravelAdvisor", b =>
                {
                    b.HasOne("Kanoo.Models.TypeaheadAutocomplete", "TypeaheadAutocomplete")
                        .WithMany("results")
                        .HasForeignKey("TypeaheadAutocompleteId");

                    b.Navigation("TypeaheadAutocomplete");
                });

            modelBuilder.Entity("Kanoo.Models.TypeaheadAutocomplete", b =>
                {
                    b.HasOne("Kanoo.Models.Data", "Data")
                        .WithMany("Typeahead_autocomplete")
                        .HasForeignKey("TypeaheadAutocompleteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Data");
                });

            modelBuilder.Entity("Kanoo.Models.TypedParams", b =>
                {
                    b.HasOne("Kanoo.Models.Route", null)
                        .WithMany("typedParams")
                        .HasForeignKey("Routeid");

                    b.HasOne("Kanoo.Models.TravelAdvisor", "TravelAdvisor")
                        .WithMany()
                        .HasForeignKey("TravelAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelAdvisor");
                });

            modelBuilder.Entity("Kanoo.Models.Contact", b =>
                {
                    b.Navigation("streetAddress");
                });

            modelBuilder.Entity("Kanoo.Models.Data", b =>
                {
                    b.Navigation("Typeahead_autocomplete");
                });

            modelBuilder.Entity("Kanoo.Models.Details", b =>
                {
                    b.Navigation("socialStatistics");
                });

            modelBuilder.Entity("Kanoo.Models.DetailsV2", b =>
                {
                    b.Navigation("contact");

                    b.Navigation("geocode");

                    b.Navigation("names");

                    b.Navigation("route");
                });

            modelBuilder.Entity("Kanoo.Models.Image", b =>
                {
                    b.Navigation("photo");
                });

            modelBuilder.Entity("Kanoo.Models.ParentGeoDetails", b =>
                {
                    b.Navigation("names");
                });

            modelBuilder.Entity("Kanoo.Models.Photo", b =>
                {
                    b.Navigation("photoSizeDynamic");

                    b.Navigation("photoSizes");
                });

            modelBuilder.Entity("Kanoo.Models.Root", b =>
                {
                    b.Navigation("Data");
                });

            modelBuilder.Entity("Kanoo.Models.Route", b =>
                {
                    b.Navigation("typedParams");
                });

            modelBuilder.Entity("Kanoo.Models.TravelAdvisor", b =>
                {
                    b.Navigation("details");

                    b.Navigation("detailsV2");

                    b.Navigation("image");

                    b.Navigation("parentGeoDetails");

                    b.Navigation("route");
                });

            modelBuilder.Entity("Kanoo.Models.TravelService", b =>
                {
                    b.Navigation("Flight");
                });

            modelBuilder.Entity("Kanoo.Models.TypeaheadAutocomplete", b =>
                {
                    b.Navigation("results");
                });
#pragma warning restore 612, 618
        }
    }
}
