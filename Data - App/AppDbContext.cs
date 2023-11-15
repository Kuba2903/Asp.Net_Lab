
using Data___App.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data___App
{
    public class AppDbContext : DbContext
    {
        public DbSet<CarEntity> Cars { get; set; }
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "car.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarEntity>().HasData(
                new CarEntity() { Id = 1, Model = "Octavia", Producent = "Skoda", PojemnoscSilnika = 2, Moc = 2, RodzajSilnika = "tdi", NrRejestracyjny = "TNB", Wlasciciel = "Wlasciciel", Priorytet = 2 },
                new CarEntity() { Id = 2, Model = "Astra", Producent = "Opel", PojemnoscSilnika = 2, Moc = 3, RodzajSilnika = "tdi", NrRejestracyjny = "KDA", Wlasciciel = "Wlasciciel2", Priorytet = 2 }
            );
        }
    }
}
