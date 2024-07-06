using CarRental.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DAL.Context
{
    public class CarContext:DbContext
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

            modelBuilder.Entity<Car>()
                .HasOne(c => c.Location)
                .WithMany(l => l.Cars)
                .HasForeignKey(c => c.LocationId);


            modelBuilder.Entity<Car>()
                .HasOne(c => c.Brand)
                .WithMany(b => b.Cars)
                .HasForeignKey(c => c.BrandId);


            modelBuilder.Entity<CarRent>()
                .HasOne(cr => cr.Car)
                .WithMany(c => c.CarRents)
                .HasForeignKey(cr => cr.CarId);


            modelBuilder.Entity<CarRent>()
                .HasOne(cr => cr.PickUpLocation)
                .WithMany(l => l.PickUpCarRents)
                .HasForeignKey(cr => cr.PickUpLocationId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<CarRent>()
                .HasOne(cr => cr.DropOffLocation)
                .WithMany(l => l.DropOffCarRents)
                .HasForeignKey(cr => cr.DropOffLocationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
