﻿// <auto-generated />
using System;
using LaboratorioAws.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LaboratorioAws.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("LaboratorioAws.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<int>("DocumentNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Starter")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1987, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 12345678,
                            DocumentType = "DNI",
                            Name = "Lionel",
                            Number = 10,
                            Position = "Delantero",
                            Starter = true,
                            Surname = "Messi"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1992, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 98765432,
                            DocumentType = "DNI",
                            Name = "Emiliano",
                            Number = 23,
                            Position = "Arquero",
                            Starter = false,
                            Surname = "Martinez"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(2001, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 13572468,
                            DocumentType = "DNI",
                            Name = "Enzo",
                            Number = 24,
                            Position = "Mediocampista",
                            Starter = true,
                            Surname = "Fernandez"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 97532468,
                            DocumentType = "DNI",
                            Name = "Gonzalo",
                            Number = 4,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Montiel"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}