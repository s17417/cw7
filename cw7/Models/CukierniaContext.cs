using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw7.Models
{
    public class CukierniaContext : DbContext
    {
        public DbSet<Klient> Klients { get; set; }

        public DbSet<Pracownik> Pracowniks { get; set; }

        public DbSet<Zamowienie> Zamowienies { get; set; }

        public DbSet<Zamowienie_WyrobCukierniczy> Zamowienie_WyrobCukierniczies { get; set; }

        public DbSet<WyrobCukierniczy> WyrobCukierniczies { get; set; }

        public CukierniaContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

          //  modelBuilder.Entity<Zamowienie_WyrobCukierniczy>().HasOne<Zamowienie_WyrobCukierniczy>()
           modelBuilder.Entity<Zamowienie_WyrobCukierniczy>().HasKey(c => new { c.IdWyrobuCukierniczego, c.IdZamowienia });

            modelBuilder.Entity<Klient>().HasData(new Klient
            {
                IdKlient=1,
                Imie="Janusz",
                Nazwisko="Januszewski"

            });

            modelBuilder.Entity<Klient>().HasData(new Klient
            {
                IdKlient = 2,
                Imie = "Mariola",
                Nazwisko = "Mariolowska"

            });


            modelBuilder.Entity<Zamowienie>().HasData(new Zamowienie
            {
                IdZamowienia=1,
                IdKlient = 1,
                DataPrzyjecia=DateTime.Now,
                Uwagi="bla bla bla",
            }) ;

            modelBuilder.Entity<Zamowienie>().HasData(new Zamowienie
            {
                IdZamowienia = 2,
                IdKlient = 2,
                DataPrzyjecia = DateTime.Now,
                Uwagi = "bla bla bla",
            });


            modelBuilder.Entity<WyrobCukierniczy>().HasData(new WyrobCukierniczy
            {
                IdWyrobuCukierniczego=1,
                Nazwa="torcik",
                CenaZaSzt=40.09f,
                Typ="malutki"
            });

            modelBuilder.Entity<WyrobCukierniczy>().HasData(new WyrobCukierniczy
            {
                IdWyrobuCukierniczego = 2,
                Nazwa = "torcicho",
                CenaZaSzt = 120.09f,
                Typ = "ogromniasty"
            });

            modelBuilder.Entity<Zamowienie_WyrobCukierniczy>().HasData(new Zamowienie_WyrobCukierniczy
            {
                
                IdWyrobuCukierniczego=1,
                IdZamowienia=1,
                Ilosc=2,
                Uwagi="zamowiony na przyjecie urodzinowe"
            });

            modelBuilder.Entity<Zamowienie_WyrobCukierniczy>().HasData(new Zamowienie_WyrobCukierniczy
            {

                IdWyrobuCukierniczego = 2,
                IdZamowienia = 1,
                Ilosc = 2,
                Uwagi = "zamowiony na przyjecie urodzinowe"
            });

        }
      
    }
}
