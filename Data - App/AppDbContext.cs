
using Data___App.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data___App
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<CarEntity> Cars { get; set; }
        public DbSet<OrganizationEntity> Organizations { get; set; }
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "cars.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string Admin_id = Guid.NewGuid().ToString();
            string Role_id = Guid.NewGuid().ToString();
            string User_id = Guid.NewGuid().ToString();
            string User_Role_id = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole()
            {
                Name = "admin",
                NormalizedName = "ADMIN",
                Id = Role_id,
                ConcurrencyStamp = Role_id
            }, new IdentityRole()
            {
                Name ="user",
                NormalizedName = "USER",
                Id = User_Role_id,
                ConcurrencyStamp = User_Role_id
            });


            var admin = new IdentityUser
            {
                Id = Admin_id,
                Email = "adam@wsei.edu.pl",
                EmailConfirmed = true,
                UserName = "adam",
                NormalizedUserName = "ADAM",
                NormalizedEmail = "ADAM@WSEI.EDU.PL"
            };

            var user = new IdentityUser
            {
                Id = User_id,
                Email = "karolina@wsei.edu.pl",
                EmailConfirmed = true,
                UserName = "karolina",
                NormalizedUserName = "KAROLINA",
                NormalizedEmail = "KAROLINA@WSEI.EDU.PL"
            };

            PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = hasher.HashPassword(admin, "1234abcd!@#$ABCD");
            user.PasswordHash = hasher.HashPassword(user, "abcd1234!AB");

            modelBuilder.Entity<IdentityUser>().HasData(admin, user);

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(new IdentityUserRole<string>
                {
                    RoleId = Role_id,
                    UserId = Admin_id
                }, new IdentityUserRole<string>
                {
                    RoleId = User_Role_id,
                    UserId = User_id
                }
                );



            modelBuilder.Entity<OrganizationEntity>()
            .OwnsOne(e => e.Address);

            modelBuilder.Entity<CarEntity>()
                .HasOne(e => e.Organization)
                .WithMany(o => o.Cars)
                .HasForeignKey(e => e.OrganizationId);


            modelBuilder.Entity<OrganizationEntity>().HasData(
             new OrganizationEntity()
             {
                 Id = 1,
                 Tytul = "WSEI",
                 Nip = "83492384",
                 Region = "13424234",
             },
             new OrganizationEntity()
             {
                 Id = 2,
                 Tytul = "Firma",
                 Nip = "2498534",
                 Region = "0873439249",
             }
            );

            modelBuilder.Entity<CarEntity>().HasData(
                new CarEntity() { Id = 1, Model = "Octavia", Producent = "Skoda", PojemnoscSilnika = 2, Moc = 2, RodzajSilnika = "tdi", NrRejestracyjny = "TNB", Wlasciciel = "Wlasciciel", Priorytet = 2, OrganizationId = 1 },
                new CarEntity() { Id = 2, Model = "Astra", Producent = "Opel", PojemnoscSilnika = 2, Moc = 3, RodzajSilnika = "tdi", NrRejestracyjny = "KDA", Wlasciciel = "Wlasciciel2", Priorytet = 2, OrganizationId = 2 }
            );

            modelBuilder.Entity<OrganizationEntity>()
           .OwnsOne(e => e.Address)
           .HasData(
               new { OrganizationEntityId = 1, Miasto = "Kraków", Ulica = "Św. Filipa 17", KodPocztowy = "31-150", Region = "małopolskie" },
               new { OrganizationEntityId = 2, Miasto = "Kraków", Ulica = "Krowoderska 45/6", KodPocztowy = "31-150", Region = "małopolskie" }
           );
        }
    }
}
