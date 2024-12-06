using System.Collections.Generic;
using System.Reflection.Emit;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data {
    public class ProjectDbContext : DbContext {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
            : base(options)
        {
        }
        //Adding original team data to the tables
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, FirstName = "Brock", LastName = "Brown", Birthdate = new DateTime(1986, 10, 19), CollegeProgram = "Information Technology", YearInProgram = "Sophomore" },
                new TeamMember { Id = 2, FirstName = "Brady", LastName = "Jacoby", Birthdate = new DateTime(1996, 07, 04), CollegeProgram = "Information Technology", YearInProgram = "Junior" },
                new TeamMember { Id = 3, FirstName = "Morgan", LastName = "Lastname", Birthdate = new DateTime(2000, 01, 01), CollegeProgram = "Major", YearInProgram = "Grade" },
                new TeamMember { Id = 4, FirstName = "Stephanie", LastName = "McKinney", Birthdate = new DateTime(1991, 02, 17), CollegeProgram = "Information Technology", YearInProgram = "Sophomore" },
                new TeamMember { Id = 5, FirstName = "Wendy", LastName = "Lastname", Birthdate = new DateTime(2000, 01, 01), CollegeProgram = "Major", YearInProgram = "Grade" }
            );

            
            builder.Entity<Hobby>().HasData(
                new Hobby { Id = 1, HobbyName = "Collecting", Category = "Coins", AnnualCost = 100, DaysPerWeek = 1 },
                new Hobby { Id = 2, HobbyName = "Mountain Biking", Category = "Sports", AnnualCost = 950, DaysPerWeek = 2 },
                new Hobby { Id = 3, HobbyName = "Volleyball", Category = "Sports", AnnualCost = 500, DaysPerWeek = 3 },
                new Hobby { Id = 4, HobbyName = "Hobby 4", Category = "Activities", AnnualCost = 500, DaysPerWeek = 2 },
                new Hobby { Id = 5, HobbyName = "Hobby 5", Category = "Activities", AnnualCost = 500, DaysPerWeek = 2 }
            );

            
            builder.Entity<FavoriteRide>().HasData(
                new FavoriteRide { Id = 1, Location = "Cedar Point", RideName = "Raptor", RideType = "Roller Coaster", MinRiderHeight = 52 },
                new FavoriteRide { Id = 2, Location = "Cedar Point", RideName = "Top Thrill Dragster", RideType = "Roller Coaster", MinRiderHeight = 52 },
                new FavoriteRide { Id = 3, Location = "Kings Island", RideName = "The Beast", RideType = "Roller Coaster", MinRiderHeight = 48 },
                new FavoriteRide { Id = 4, Location = "Hershey Park", RideName = "Storm Runner", RideType = "Roller Coaster", MinRiderHeight = 42 },
                new FavoriteRide { Id = 5, Location = "Disney World", RideName = "Space Mountain", RideType = "Thriller", MinRiderHeight = 40 }
            );


            builder.Entity<FavoriteFood>().HasData(
                new FavoriteFood { Id = 1, FoodName = "Steak", Calories = 400, IsVegetarian = false, MealOfDay = "Any" },
                new FavoriteFood { Id = 2, FoodName = "Mac n' Cheese", Calories = 320, IsVegetarian = true, MealOfDay = "Lunch" },
                new FavoriteFood { Id = 3, FoodName = "Ice Cream", Calories = 460, IsVegetarian = true, MealOfDay = "Dessert" },
                new FavoriteFood { Id = 4, FoodName = "Pepperoni Pizza", Calories = 380, IsVegetarian = false, MealOfDay = "Dinner" },
                new FavoriteFood { Id = 5, FoodName = "Cereal", Calories = 280, IsVegetarian = true, MealOfDay = "Breakfast" }
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
