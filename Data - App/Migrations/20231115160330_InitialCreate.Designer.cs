﻿// <auto-generated />
using Data___App;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data___App.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231115160330_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Data___App.Entities.CarEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Moc")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("TEXT");

                    b.Property<string>("NrRejestracyjny")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PojemnoscSilnika")
                        .HasColumnType("TEXT");

                    b.Property<byte>("Priorytet")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Producent")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("TEXT");

                    b.Property<string>("RodzajSilnika")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("TEXT");

                    b.Property<string>("Wlasciciel")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Moc = 2,
                            Model = "Octavia",
                            NrRejestracyjny = "TNB",
                            PojemnoscSilnika = 2m,
                            Priorytet = (byte)2,
                            Producent = "Skoda",
                            RodzajSilnika = "tdi",
                            Wlasciciel = "Wlasciciel"
                        },
                        new
                        {
                            Id = 2,
                            Moc = 3,
                            Model = "Astra",
                            NrRejestracyjny = "KDA",
                            PojemnoscSilnika = 2m,
                            Priorytet = (byte)2,
                            Producent = "Opel",
                            RodzajSilnika = "tdi",
                            Wlasciciel = "Wlasciciel2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
