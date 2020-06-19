﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cw7.Models;

namespace cw7.Migrations
{
    [DbContext(typeof(CukierniaContext))]
    partial class CukierniaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cw7.Models.Klient", b =>
                {
                    b.Property<int>("IdKlient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdKlient");

                    b.ToTable("Klients");

                    b.HasData(
                        new
                        {
                            IdKlient = 1,
                            Imie = "Janusz",
                            Nazwisko = "Januszewski"
                        },
                        new
                        {
                            IdKlient = 2,
                            Imie = "Mariola",
                            Nazwisko = "Mariolowska"
                        });
                });

            modelBuilder.Entity("cw7.Models.Pracownik", b =>
                {
                    b.Property<int>("IdPracownik")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdPracownik");

                    b.ToTable("Pracowniks");
                });

            modelBuilder.Entity("cw7.Models.WyrobCukierniczy", b =>
                {
                    b.Property<int>("IdWyrobuCukierniczego")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CenaZaSzt")
                        .HasColumnType("real");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("IdWyrobuCukierniczego");

                    b.ToTable("WyrobCukierniczies");

                    b.HasData(
                        new
                        {
                            IdWyrobuCukierniczego = 1,
                            CenaZaSzt = 40.09f,
                            Nazwa = "torcik",
                            Typ = "malutki"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 2,
                            CenaZaSzt = 120.09f,
                            Nazwa = "torcicho",
                            Typ = "ogromniasty"
                        });
                });

            modelBuilder.Entity("cw7.Models.Zamowienie", b =>
                {
                    b.Property<int>("IdZamowienia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataPrzyjecia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRealizacji")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdKlient")
                        .HasColumnType("int");

                    b.Property<int?>("IdPracownik")
                        .HasColumnType("int");

                    b.Property<string>("Uwagi")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("IdZamowienia");

                    b.HasIndex("IdKlient");

                    b.HasIndex("IdPracownik");

                    b.ToTable("Zamowienies");

                    b.HasData(
                        new
                        {
                            IdZamowienia = 1,
                            DataPrzyjecia = new DateTime(2020, 6, 19, 9, 15, 50, 379, DateTimeKind.Local).AddTicks(307),
                            DataRealizacji = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdKlient = 1,
                            Uwagi = "bla bla bla"
                        },
                        new
                        {
                            IdZamowienia = 2,
                            DataPrzyjecia = new DateTime(2020, 6, 19, 9, 15, 50, 383, DateTimeKind.Local).AddTicks(3209),
                            DataRealizacji = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdKlient = 2,
                            Uwagi = "bla bla bla"
                        });
                });

            modelBuilder.Entity("cw7.Models.Zamowienie_WyrobCukierniczy", b =>
                {
                    b.Property<int>("IdWyrobuCukierniczego")
                        .HasColumnType("int");

                    b.Property<int>("IdZamowienia")
                        .HasColumnType("int");

                    b.Property<int>("Ilosc")
                        .HasColumnType("int");

                    b.Property<string>("Uwagi")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("IdWyrobuCukierniczego", "IdZamowienia");

                    b.HasIndex("IdZamowienia");

                    b.ToTable("Zamowienie_WyrobCukierniczies");

                    b.HasData(
                        new
                        {
                            IdWyrobuCukierniczego = 1,
                            IdZamowienia = 1,
                            Ilosc = 2,
                            Uwagi = "zamowiony na przyjecie urodzinowe"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 2,
                            IdZamowienia = 1,
                            Ilosc = 2,
                            Uwagi = "zamowiony na przyjecie urodzinowe"
                        });
                });

            modelBuilder.Entity("cw7.Models.Zamowienie", b =>
                {
                    b.HasOne("cw7.Models.Klient", "Klient")
                        .WithMany("Zamowienia")
                        .HasForeignKey("IdKlient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cw7.Models.Pracownik", "Pracownik")
                        .WithMany("Zamowienia")
                        .HasForeignKey("IdPracownik");
                });

            modelBuilder.Entity("cw7.Models.Zamowienie_WyrobCukierniczy", b =>
                {
                    b.HasOne("cw7.Models.WyrobCukierniczy", "WyrobCukierniczy")
                        .WithMany("Zamowienia_WyrobyCukiernicze")
                        .HasForeignKey("IdWyrobuCukierniczego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cw7.Models.Zamowienie", "Zamowienie")
                        .WithMany("Zamowienie_WyrobyCukiernicze")
                        .HasForeignKey("IdZamowienia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
