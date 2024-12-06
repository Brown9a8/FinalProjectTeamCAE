using System.Collections.Generic;
using System.Reflection.Emit;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
            : base(options)
        {
        }
        //Adding original team data to the tables
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, FirstName = "Brock", LastName = "Brown", Birthdate = "10/19/1986", CollegeProgram = "Information Technology", YearInProgram = "Sophmore" }
                );
            builder.Entity<Hobby>().HasData(
                new Hobby { Id = 1, HobbyName = "Collecting", Category = "Coins", AnnualCost = 100, DaysPerWeek = 1 }
                );
            builder.Entity<FavoriteRide>().HasData(
                new FavoriteRide { Id = 1, Location = "CedarPoint", RideName = "Raptor", RideType = "rollercoaster", MinRiderHeight = 52 }
                );
            builder.Entity<FavoriteFood>().HasData(
                new FavoriteFood { Id = 1, FoodName = "Steak", MealOfDay = "Any", Calories = 400, IsVegetarian = false }
                );
        }
        public DbSet<TeamMember> Members { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<FavoriteFood> FavoriteFoods { get; set; }
        public DbSet<FavoriteRide> FavoriteRides { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TeamCAE;Trusted_Connection=True;MultipleActiveResultSets=True");
        }
    }
}
