﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Data;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240419201135_datamigration")]
    partial class datamigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.29");

            modelBuilder.Entity("Model.Entities.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FoundationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Club");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FoundationDate = new DateTime(1901, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Manager = "Marcelo Gallardo",
                            Name = "River Plate"
                        },
                        new
                        {
                            Id = 2,
                            FoundationDate = new DateTime(1905, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Manager = "Miguel Ángel Russo",
                            Name = "Boca Juniors"
                        },
                        new
                        {
                            Id = 3,
                            FoundationDate = new DateTime(1905, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Manager = "Julio Falcioni",
                            Name = "Independiente"
                        },
                        new
                        {
                            Id = 4,
                            FoundationDate = new DateTime(1905, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Manager = "Eduardo Coudet",
                            Name = "Racing"
                        });
                });

            modelBuilder.Entity("Model.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClubId")
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

                    b.HasIndex("ClubId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClubId = 1,
                            DateOfBirth = new DateTime(1986, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 12345678,
                            DocumentType = "DNI",
                            Name = "Franco",
                            Number = 1,
                            Position = "Arquero",
                            Starter = true,
                            Surname = "Armani"
                        },
                        new
                        {
                            Id = 2,
                            ClubId = 1,
                            DateOfBirth = new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 23456789,
                            DocumentType = "DNI",
                            Name = "Gonzalo",
                            Number = 4,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Montiel"
                        },
                        new
                        {
                            Id = 3,
                            ClubId = 1,
                            DateOfBirth = new DateTime(1983, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 34567890,
                            DocumentType = "DNI",
                            Name = "Javier",
                            Number = 22,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Pinola"
                        },
                        new
                        {
                            Id = 4,
                            ClubId = 1,
                            DateOfBirth = new DateTime(1996, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 45678901,
                            DocumentType = "DNI",
                            Name = "Lucas",
                            Number = 29,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Martínez Quarta"
                        },
                        new
                        {
                            Id = 5,
                            ClubId = 1,
                            DateOfBirth = new DateTime(1988, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 56789012,
                            DocumentType = "DNI",
                            Name = "Milton",
                            Number = 20,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Casco"
                        },
                        new
                        {
                            Id = 6,
                            ClubId = 1,
                            DateOfBirth = new DateTime(1998, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 67890123,
                            DocumentType = "DNI",
                            Name = "Exequiel",
                            Number = 15,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Palacios"
                        },
                        new
                        {
                            Id = 7,
                            ClubId = 1,
                            DateOfBirth = new DateTime(1982, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 78901234,
                            DocumentType = "DNI",
                            Name = "Leonardo",
                            Number = 23,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Ponzio"
                        },
                        new
                        {
                            Id = 8,
                            ClubId = 1,
                            DateOfBirth = new DateTime(1990, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 89012345,
                            DocumentType = "DNI",
                            Name = "Ignacio",
                            Number = 26,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Fernández"
                        },
                        new
                        {
                            Id = 9,
                            ClubId = 1,
                            DateOfBirth = new DateTime(1995, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 90123456,
                            DocumentType = "DNI",
                            Name = "Rafael",
                            Number = 19,
                            Position = "Delantero",
                            Starter = true,
                            Surname = "Santos Borré"
                        },
                        new
                        {
                            Id = 10,
                            ClubId = 1,
                            DateOfBirth = new DateTime(1988, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 1234567,
                            DocumentType = "DNI",
                            Name = "Lucas",
                            Number = 27,
                            Position = "Delantero",
                            Starter = true,
                            Surname = "Pratto"
                        },
                        new
                        {
                            Id = 11,
                            ClubId = 1,
                            DateOfBirth = new DateTime(1993, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 12345678,
                            DocumentType = "DNI",
                            Name = "Juan Fernando",
                            Number = 8,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Quintero"
                        },
                        new
                        {
                            Id = 12,
                            ClubId = 2,
                            DateOfBirth = new DateTime(1995, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 12345678,
                            DocumentType = "DNI",
                            Name = "Agustín",
                            Number = 1,
                            Position = "Arquero",
                            Starter = true,
                            Surname = "Rossi"
                        },
                        new
                        {
                            Id = 13,
                            ClubId = 2,
                            DateOfBirth = new DateTime(1991, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 23456789,
                            DocumentType = "DNI",
                            Name = "Leonardo",
                            Number = 29,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Jara"
                        },
                        new
                        {
                            Id = 14,
                            ClubId = 2,
                            DateOfBirth = new DateTime(1989, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 34567890,
                            DocumentType = "DNI",
                            Name = "Carlos",
                            Number = 24,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Izquierdoz"
                        },
                        new
                        {
                            Id = 15,
                            ClubId = 2,
                            DateOfBirth = new DateTime(1993, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 45678901,
                            DocumentType = "DNI",
                            Name = "Lisandro",
                            Number = 6,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Magallán"
                        },
                        new
                        {
                            Id = 16,
                            ClubId = 2,
                            DateOfBirth = new DateTime(1989, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 56789012,
                            DocumentType = "DNI",
                            Name = "Emmanuel",
                            Number = 3,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Mas"
                        },
                        new
                        {
                            Id = 17,
                            ClubId = 2,
                            DateOfBirth = new DateTime(1995, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 67890123,
                            DocumentType = "DNI",
                            Name = "Nahitan",
                            Number = 15,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Nández"
                        },
                        new
                        {
                            Id = 18,
                            ClubId = 2,
                            DateOfBirth = new DateTime(1993, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 78901234,
                            DocumentType = "DNI",
                            Name = "Wilmar",
                            Number = 16,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Barrios"
                        },
                        new
                        {
                            Id = 19,
                            ClubId = 2,
                            DateOfBirth = new DateTime(1985, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 89012345,
                            DocumentType = "DNI",
                            Name = "Pablo",
                            Number = 8,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Pérez"
                        },
                        new
                        {
                            Id = 20,
                            ClubId = 2,
                            DateOfBirth = new DateTime(1996, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 90123456,
                            DocumentType = "DNI",
                            Name = "Cristian",
                            Number = 7,
                            Position = "Delantero",
                            Starter = true,
                            Surname = "Pavón"
                        },
                        new
                        {
                            Id = 21,
                            ClubId = 2,
                            DateOfBirth = new DateTime(1989, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 1234567,
                            DocumentType = "DNI",
                            Name = "Ramón",
                            Number = 9,
                            Position = "Delantero",
                            Starter = true,
                            Surname = "Ábila"
                        },
                        new
                        {
                            Id = 22,
                            ClubId = 2,
                            DateOfBirth = new DateTime(1990, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 12345678,
                            DocumentType = "DNI",
                            Name = "Darío",
                            Number = 9,
                            Position = "Delantero",
                            Starter = true,
                            Surname = "Benedetto"
                        },
                        new
                        {
                            Id = 23,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1989, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 12345678,
                            DocumentType = "DNI",
                            Name = "Martín",
                            Number = 1,
                            Position = "Arquero",
                            Starter = true,
                            Surname = "Campaña"
                        },
                        new
                        {
                            Id = 24,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1996, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 23456789,
                            DocumentType = "DNI",
                            Name = "Alan",
                            Number = 2,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Franco"
                        },
                        new
                        {
                            Id = 25,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1992, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 34567890,
                            DocumentType = "DNI",
                            Name = "Nicolás",
                            Number = 3,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Tagliafico"
                        },
                        new
                        {
                            Id = 26,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1994, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 45678901,
                            DocumentType = "DNI",
                            Name = "Gastón",
                            Number = 4,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Silva"
                        },
                        new
                        {
                            Id = 27,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1996, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 56789012,
                            DocumentType = "DNI",
                            Name = "Fabricio",
                            Number = 16,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Bustos"
                        },
                        new
                        {
                            Id = 28,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1986, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 67890123,
                            DocumentType = "DNI",
                            Name = "Pablo",
                            Number = 10,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Hernández"
                        },
                        new
                        {
                            Id = 29,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1992, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 78901234,
                            DocumentType = "DNI",
                            Name = "Maximiliano",
                            Number = 11,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Meza"
                        },
                        new
                        {
                            Id = 30,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1999, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 89012345,
                            DocumentType = "DNI",
                            Name = "Ezequiel",
                            Number = 20,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Barco"
                        },
                        new
                        {
                            Id = 31,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1987, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 90123456,
                            DocumentType = "DNI",
                            Name = "Emmanuel",
                            Number = 9,
                            Position = "Delantero",
                            Starter = true,
                            Surname = "Gigliotti"
                        },
                        new
                        {
                            Id = 32,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1991, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 1234567,
                            DocumentType = "DNI",
                            Name = "Fernando",
                            Number = 15,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Gaibor"
                        },
                        new
                        {
                            Id = 33,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1994, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 12345678,
                            DocumentType = "DNI",
                            Name = "Martín",
                            Number = 8,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Benítez"
                        },
                        new
                        {
                            Id = 34,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1989, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 12345678,
                            DocumentType = "DNI",
                            Name = "Martín",
                            Number = 1,
                            Position = "Arquero",
                            Starter = true,
                            Surname = "Campaña"
                        },
                        new
                        {
                            Id = 35,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1996, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 23456789,
                            DocumentType = "DNI",
                            Name = "Alan",
                            Number = 2,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Franco"
                        },
                        new
                        {
                            Id = 36,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1992, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 34567890,
                            DocumentType = "DNI",
                            Name = "Nicolás",
                            Number = 3,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Tagliafico"
                        },
                        new
                        {
                            Id = 37,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1994, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 45678901,
                            DocumentType = "DNI",
                            Name = "Gastón",
                            Number = 4,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Silva"
                        },
                        new
                        {
                            Id = 38,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1996, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 56789012,
                            DocumentType = "DNI",
                            Name = "Fabricio",
                            Number = 16,
                            Position = "Defensor",
                            Starter = true,
                            Surname = "Bustos"
                        },
                        new
                        {
                            Id = 39,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1986, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 67890123,
                            DocumentType = "DNI",
                            Name = "Pablo",
                            Number = 10,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Hernández"
                        },
                        new
                        {
                            Id = 40,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1992, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 78901234,
                            DocumentType = "DNI",
                            Name = "Maximiliano",
                            Number = 11,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Meza"
                        },
                        new
                        {
                            Id = 41,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1999, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 89012345,
                            DocumentType = "DNI",
                            Name = "Ezequiel",
                            Number = 20,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Barco"
                        },
                        new
                        {
                            Id = 42,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1987, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 90123456,
                            DocumentType = "DNI",
                            Name = "Emmanuel",
                            Number = 9,
                            Position = "Delantero",
                            Starter = true,
                            Surname = "Gigliotti"
                        },
                        new
                        {
                            Id = 43,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1991, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 1234567,
                            DocumentType = "DNI",
                            Name = "Fernando",
                            Number = 15,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Gaibor"
                        },
                        new
                        {
                            Id = 44,
                            ClubId = 3,
                            DateOfBirth = new DateTime(1994, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = 12345678,
                            DocumentType = "DNI",
                            Name = "Martín",
                            Number = 8,
                            Position = "Centrocampista",
                            Starter = true,
                            Surname = "Benítez"
                        });
                });

            modelBuilder.Entity("Model.Entities.Stadium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClubId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Stadium");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 86000,
                            ClubId = 1,
                            Location = "Buenos Aires",
                            Name = "Monumental"
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 57000,
                            ClubId = 2,
                            Location = "Buenos Aires",
                            Name = "La Bombonera"
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 48000,
                            ClubId = 3,
                            Location = "Avellaneda",
                            Name = "Libertadores de América"
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 53000,
                            ClubId = 4,
                            Location = "Avellaneda",
                            Name = "Presidente Perón"
                        });
                });

            modelBuilder.Entity("Model.Entities.Player", b =>
                {
                    b.HasOne("Model.Entities.Club", "Club")
                        .WithMany("Players")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Club");
                });

            modelBuilder.Entity("Model.Entities.Stadium", b =>
                {
                    b.HasOne("Model.Entities.Club", "Owner")
                        .WithMany()
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Model.Entities.Club", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
