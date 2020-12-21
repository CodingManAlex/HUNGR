using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUNGR.API.Models
{
    public class HUNGRContext : DbContext
    {
        public HUNGRContext(DbContextOptions<HUNGRContext> options) : base(options) 
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Events
            modelBuilder.Entity<Event>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Event>()
                .Property(e => e.Image).HasMaxLength(500);
            //FoodTruck
            modelBuilder.Entity<FoodTruck>()
                .HasKey(f => f.FoodTruckId);
            modelBuilder.Entity<FoodTruck>()
                .HasMany(f => f.Reviews)
                .WithOne(r => r.FoodTruck)
                .HasForeignKey(r => r.FoodTruckId);
            //User Profiles
            modelBuilder.Entity<StandardUserProfile>()
                .HasKey(u => u.Id);
            modelBuilder.Entity<StandardUserProfile>()
                .HasMany(u => u.Reviews)
                .WithOne(r => r.StandardUserProfile)
                .HasForeignKey(r => r.Id);
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
                .HasForeignKey(ep => ep.EventId);
            modelBuilder.Entity<EventParticipant>()
                .HasOne<FoodTruck>(ep => ep.FoodTruck)
                .WithMany(f=>f.EventParticipants)
                .HasForeignKey(ep => ep.FoodTruckId);

            //UserFavouriteFood
            modelBuilder.Entity<UserFavouriteFood>().HasKey(ff => new { ff.UserId, ff.FoodCategoryId });
            modelBuilder.Entity<UserFavouriteFood>()
                .HasOne<StandardUserProfile>(ff => ff.StandardUserProfile)
                .WithMany(u => u.UserFavouriteFoods)
                .HasForeignKey(ff => ff.UserId);
            modelBuilder.Entity<UserFavouriteFood>()
                .HasOne<FoodCategory>(ff => ff.FoodCategory)
                .WithMany(f => f.UserFavouriteFoods)
                .HasForeignKey(ff => ff.FoodCategoryId);

            //UserFavouriteTruck
            modelBuilder.Entity<UserFavouriteTruck>().HasKey(ft => new { ft.UserId, ft.FoodTruckId });
            modelBuilder.Entity<UserFavouriteTruck>()
                .HasOne<StandardUserProfile>(ft => ft.StandardUserProfile)
                .WithMany(u => u.UserFavouriteTrucks)
                .HasForeignKey(ft => ft.UserId);
            modelBuilder.Entity<UserFavouriteTruck>()
                .HasOne<FoodTruck>(ft => ft.FoodTruck)
                .WithMany(f => f.UserFavouriteTrucks)
                .HasForeignKey(ft => ft.FoodTruckId);
        }

        public DbSet<FoodTruck> FoodTrucks { get; set; }
        public DbSet<StandardUserProfile> StandardUserProfiles { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }

        //"JoinTables"
        public DbSet<EventParticipant> EventParticipants { get; set; }
        public DbSet<UserFavouriteFood> UserFavouriteFoods { get; set; }
        public DbSet<UserFavouriteTruck> UserFavouriteTrucks { get; set; }
    }
}
