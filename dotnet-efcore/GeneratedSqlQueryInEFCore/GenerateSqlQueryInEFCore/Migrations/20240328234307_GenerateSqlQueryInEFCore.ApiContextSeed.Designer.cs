﻿// <auto-generated />
using GenerateSqlQueryInEFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GenerateSqlQueryInEFCore.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20240328234307_GenerateSqlQueryInEFCore.ApiContextSeed")]
    partial class GenerateSqlQueryInEFCoreApiContextSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GenerateSqlQueryInEFCore.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "BMW",
                            Model = "1 Series",
                            Name = "118d HatchBack",
                            Year = 2012
                        },
                        new
                        {
                            Id = 2,
                            Brand = "BMW",
                            Model = "1 Series",
                            Name = "118d M Sport 3 Door HatchBack",
                            Year = 2013
                        },
                        new
                        {
                            Id = 3,
                            Brand = "BMW",
                            Model = "2 Series",
                            Name = "228i Sport Convertible",
                            Year = 2015
                        },
                        new
                        {
                            Id = 4,
                            Brand = "BMW",
                            Model = "3 Series",
                            Name = "328i HatchBack",
                            Year = 2016
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
