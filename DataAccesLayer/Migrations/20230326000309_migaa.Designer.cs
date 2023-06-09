﻿// <auto-generated />
using System;
using DataAccesLayer.concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccesLayer.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20230326000309_migaa")]
    partial class migaa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EntitiyLayer.Concrete.About", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AboutDetails")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntitiyLayer.Concrete.Announcement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AnnouncementContent")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("AnnouncementStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("AnnouncementTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CratedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("EntitiyLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ContactMessage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ContactUserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
