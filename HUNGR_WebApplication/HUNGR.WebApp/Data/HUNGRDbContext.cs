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

            modelBuilder.Entity<UserFavouriteTruck>().HasData(
                new UserFavouriteTruck
                {
                    FoodTruckId = "7ce48b1b-2e9d-4c80-8253-94bad98fce8c",
                    Id = "8e378249-d83b-468b-b0ca-397174f18d1c"
                }
                );

            modelBuilder.Entity<Review>().HasData(
                    new Review
                    {
                        Id = 1,
                        Title = "Shucking Great",
                        Body = "This was an oyster experience unlink any Ive had before! These guys really know what they're doing! I'll be stopping by again very shortly!",
                        Rating = 5,
                        UserId = "8e378249-d83b-468b-b0ca-397174f18d1c",
                        FoodTruckId = "7ce48b1b-2e9d-4c80-8253-94bad98fce8c"
                    },
                    new Review
                    {
                        Id = 2,
                        Title = "Great Oyster",
                        Body = "These guys really know what they're doing! These were the best oysters I've ever had. Go show these boys some love!",
                        Rating = 5,
                        UserId = "bf3b32f9-332b-45fb-b5ee-da51fe3df482",
                        FoodTruckId = "7ce48b1b-2e9d-4c80-8253-94bad98fce8c"
                    }
                );


            //Events
            modelBuilder.Entity<Event>()
                .HasKey(e => e.Id);
            //modelBuilder.Entity<Event>()
            //    .Property(e => e.Image).HasMaxLength(500);

            //Application User
            //modelBuilder.Entity<ApplicationUser>()
            //    .HasKey(au => au.Id);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(au => au.Reviews)
                .WithOne(r => r.ApplicationUser)
                .HasForeignKey(r => r.UserId);
                



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
                .HasForeignKey(r => r.FoodTruckId)
                .OnDelete(DeleteBehavior.SetNull);

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
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EventParticipant>()
                .HasOne<FoodTruck>(ep => ep.FoodTruck)
                .WithMany(f => f.EventParticipants)
                .HasForeignKey(ep => ep.FoodTruckId)
                .OnDelete(DeleteBehavior.Cascade);

            //UserFavouriteFood
            modelBuilder.Entity<UserFavouriteFood>().HasKey(ff => new { ff.Id, ff.FoodCat });

            modelBuilder.Entity<UserFavouriteFood>()
                .HasOne<ApplicationUser>(ff => ff.ApplicationUser)
                .WithMany(u => u.UserFavouriteFoods)
                .HasForeignKey(ff => ff.Id)
                .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<UserFavouriteFood>()
            //            .HasOne<FoodCat>(ff => ff.FoodCat)
            //            .WithMany(f => f.UserFavouriteFoods)
            //            .HasForeignKey(ff => ff.FoodCat)
            //            .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<UserFavouriteFood>().HasKey(ff => new { ff.Id, ff.FoodCategoryId });
            //modelBuilder.Entity<UserFavouriteFood>()
            //    .HasOne<ApplicationUser>(ff => ff.ApplicationUser)
            //    .WithMany(u => u.UserFavouriteFoods)
            //    .HasForeignKey(ff => ff.Id)
            //    .OnDelete(DeleteBehavior.Restrict);
            //modelBuilder.Entity<UserFavouriteFood>()
            //    .HasOne<FoodCategory>(ff => ff.FoodCategory)
            //    .WithMany(f => f.UserFavouriteFoods)
            //    .HasForeignKey(ff => ff.FoodCategoryId)
            //    .OnDelete(DeleteBehavior.Restrict);

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
                .OnDelete(DeleteBehavior.Cascade);

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
