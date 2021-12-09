﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RoomClimateRecord.API.Brokers;

#nullable disable

namespace RoomClimateRecord.API.Migrations
{
    [DbContext(typeof(StorageBroker))]
    [Migration("20211209001340_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RoomClimateRecord.API.Models.Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<short>("Humidity")
                        .HasColumnType("smallint");

                    b.Property<bool>("Motion")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("Stamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<short>("Temperature")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("records");
                });
#pragma warning restore 612, 618
        }
    }
}
