﻿// <auto-generated />
using System;
using EventsAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EventsAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241022213403_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EventsAPI.Models.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateOnly>("DATE")
                        .HasColumnType("date");

                    b.Property<int>("EVENT_TYPE")
                        .HasColumnType("integer");

                    b.Property<TimeOnly>("TIME")
                        .HasColumnType("time without time zone");

                    b.HasKey("ID");

                    b.ToTable("Event", "Events");
                });

            modelBuilder.Entity("EventsAPI.Models.EventType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<bool>("ARCHIVE")
                        .HasColumnType("boolean");

                    b.Property<int>("CAPACITY")
                        .HasColumnType("integer");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("ID");

                    b.ToTable("EventType", "Events");
                });

            modelBuilder.Entity("EventsAPI.Models.EventUser", b =>
                {
                    b.Property<int>("EVENT_ID")
                        .HasColumnType("integer");

                    b.Property<int>("USER_ID")
                        .HasColumnType("integer");

                    b.HasIndex("USER_ID", "EVENT_ID")
                        .IsUnique();

                    b.ToTable("EventUser", "Events");
                });

            modelBuilder.Entity("EventsAPI.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("EMAIL")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FIRST_NAME")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LAST_NAME")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PASSWORD")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ROLE")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("User", "Events");
                });
#pragma warning restore 612, 618
        }
    }
}
