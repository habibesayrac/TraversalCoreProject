﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SignalRApi.DAL;

#nullable disable

namespace SignalRApi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231205114107_mig_second")]
    partial class mig_second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SignalRApi.DAL.Visitor", b =>
                {
                    b.Property<int>("VisitorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitorID"));

                    b.Property<int>("City")
                        .HasColumnType("int");

                    b.Property<int>("CityVisitCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("datetime2");

                    b.HasKey("VisitorID");

                    b.ToTable("Visitors");
                });
#pragma warning restore 612, 618
        }
    }
}
