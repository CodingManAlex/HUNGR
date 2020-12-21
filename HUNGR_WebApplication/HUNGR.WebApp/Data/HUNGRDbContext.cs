using System;
using System.Collections.Generic;
using System.Text;
using HUNGR.WebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HUNGR.WebApp.Data
{
    public class HUNGRDbContext : IdentityDbContext<ApplicationUser>
    {
        public HUNGRDbContext(DbContextOptions<HUNGRDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Events
            modelBuilder.Entity<Event>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Event>()
                .Property(e => e.Image).HasMaxLength(500);

            //Application User
            //modelBuilder.Entity<ApplicationUser>()
            //    .HasKey(au => au.Id);
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(au => au.Reviews)
                .WithOne(r => r.ApplicationUser)
                .HasForeignKey(r => r.Id);
            
            

            //FoodTruck
            modelBuilder.Entity<FoodTruck>()
                .HasKey(f => f.FoodTruckId);
            modelBuilder.Entity<FoodTruck>()
                .HasOne(au => au.ApplicationUser)
                .WithOne(ft => ft.FoodTruck)
                .HasForeignKey<FoodTruck>(ft => ft.FoodTruckId);

            modelBuilder.Entity<FoodTruck>()
                .HasMany(f => f.Reviews)
                .WithOne(r => r.FoodTruck)
                .HasForeignKey(r => r.FoodTruckId);
            
            //Reviews
            modelBuilder.Entity<Review>()
                .HasKey(r => r.Id);
            //FoodCategory
            modelBuilder.Entity<FoodCategory>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<FoodCategory>()
                .HasMany(c => c.FoodTrucks)
                .WithOne(f => f.FoodCategory)
                .HasForeignKey(f => f.FoodCategoryId);

            //NavMapping
            //EventParticipant
            modelBuilder.Entity<EventParticipant>().HasKey(ep => new { ep.EventId, ep.FoodTruckId });
            modelBuilder.Entity<EventParticipant>()
                .HasOne<Event>(ep => ep.Event)
                .WithMany(e => e.EventParticipants)
                .HasForeignKey(ep => ep.EventId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EventParticipant>()
                .HasOne<FoodTruck>(ep => ep.FoodTruck)
                .WithMany(f => f.EventParticipants)
                .HasForeignKey(ep => ep.FoodTruckId)
                .OnDelete(DeleteBehavior.Restrict);

            //UserFavouriteFood
            modelBuilder.Entity<UserFavouriteFood>().HasKey(ff => new { ff.Id, ff.FoodCategoryId });
            modelBuilder.Entity<UserFavouriteFood>()
                .HasOne<ApplicationUser>(ff => ff.ApplicationUser)
                .WithMany(u => u.UserFavouriteFoods)
                .HasForeignKey(ff => ff.Id)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserFavouriteFood>()
                .HasOne<FoodCategory>(ff => ff.FoodCategory)
                .WithMany(f => f.UserFavouriteFoods)
                .HasForeignKey(ff => ff.FoodCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            //UserFavouriteTruck
            modelBuilder.Entity<UserFavouriteTruck>().HasKey(ft => new { ft.Id, ft.FoodTruckId });
            modelBuilder.Entity<UserFavouriteTruck>()
                .HasOne<ApplicationUser>(ft => ft.ApplicationUser)
                .WithMany(u => u.UserFavouriteTrucks)
                .HasForeignKey(ft => ft.Id)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserFavouriteTruck>()
                .HasOne<FoodTruck>(ft => ft.FoodTruck)
                .WithMany(f => f.UserFavouriteTrucks)
                .HasForeignKey(ft => ft.FoodTruckId)
                .OnDelete(DeleteBehavior.Restrict);

        }
        public DbSet<FoodTruck> FoodTrucks { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }

        //"JoinTables"
        public DbSet<EventParticipant> EventParticipants { get; set; }
        public DbSet<UserFavouriteFood> UserFavouriteFoods { get; set; }
        public DbSet<UserFavouriteTruck> UserFavouriteTrucks { get; set; }
    }
}
