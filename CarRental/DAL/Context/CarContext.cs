using CarRental.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DAL.Context
{
    public class CarContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("SERVER=DESKTOP-ER46C3V;initial catalog=DbCarRental;integrated security=true");
        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarRent> CarRents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarRent>()
                .HasOne(cr => cr.PickUpLocation)
                .WithMany(l => l.PickUpRentals)
                .HasForeignKey(cr => cr.PickUpLocationId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<CarRent>()
                .HasOne(cr => cr.DropOffLocation)
                .WithMany(l => l.DropOffRentals)
                .HasForeignKey(cr => cr.DropOffLocationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<IdentityUserLogin<int>>()
                .HasKey(login => new { login.LoginProvider, login.ProviderKey });

            modelBuilder.Entity<IdentityUserRole<int>>()
                .HasKey(userRole => new { userRole.UserId, userRole.RoleId });

            modelBuilder.Entity<IdentityUserToken<int>>()
                .HasKey(userToken => new { userToken.UserId, userToken.LoginProvider, userToken.Name });

        }
    }
}
