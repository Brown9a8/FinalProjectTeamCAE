﻿// <auto-generated />
using System;
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    partial class ProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FinalProject.Models.FavoriteFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVegetarian")
                        .HasColumnType("bit");

                    b.Property<string>("MealOfDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FavoriteFoods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calories = 400,
                            FoodName = "Steak",
                            IsVegetarian = false,
                            MealOfDay = "Any"
                        },
                        new
                        {
                            Id = 2,
                            Calories = 320,
                            FoodName = "Mac n' Cheese",
                            IsVegetarian = true,
                            MealOfDay = "Lunch"
                        },
                        new
                        {
                            Id = 3,
                            Calories = 460,
                            FoodName = "Ice Cream",
                            IsVegetarian = true,
                            MealOfDay = "Dessert"
                        },
                        new
                        {
                            Id = 4,
                            Calories = 380,
                            FoodName = "Pepperoni Pizza",
                            IsVegetarian = false,
                            MealOfDay = "Dinner"
                        },
                        new
                        {
                            Id = 5,
                            Calories = 280,
                            FoodName = "Cereal",
                            IsVegetarian = true,
                            MealOfDay = "Breakfast"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.FavoriteRide", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MinRiderHeight")
                        .HasColumnType("int");

                    b.Property<string>("RideName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RideType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FavoriteRides");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "Cedar Point",
                            MinRiderHeight = 52,
                            RideName = "Raptor",
                            RideType = "Roller Coaster"
                        },
                        new
                        {
                            Id = 2,
                            Location = "Cedar Point",
                            MinRiderHeight = 52,
                            RideName = "Top Thrill Dragster",
                            RideType = "Roller Coaster"
                        },
                        new
                        {
                            Id = 3,
                            Location = "Kings Island",
                            MinRiderHeight = 48,
                            RideName = "The Beast",
                            RideType = "Roller Coaster"
                        },
                        new
                        {
                            Id = 4,
                            Location = "Hershey Park",
                            MinRiderHeight = 42,
                            RideName = "Storm Runner",
                            RideType = "Roller Coaster"
                        },
                        new
                        {
                            Id = 5,
                            Location = "Disney World",
                            MinRiderHeight = 40,
                            RideName = "Space Mountain",
                            RideType = "Thriller"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.Hobby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AnnualCost")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DaysPerWeek")
                        .HasColumnType("int");

                    b.Property<string>("HobbyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hobbies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnnualCost = 100,
                            Category = "Coins",
                            DaysPerWeek = 1,
                            HobbyName = "Collecting"
                        },
                        new
                        {
                            Id = 2,
                            AnnualCost = 950,
                            Category = "Sports",
                            DaysPerWeek = 2,
                            HobbyName = "Mountain Biking"
                        },
                        new
                        {
                            Id = 3,
                            AnnualCost = 500,
                            Category = "Sports",
                            DaysPerWeek = 3,
                            HobbyName = "Volleyball"
                        },
                        new
                        {
                            Id = 4,
                            AnnualCost = 1000,
                            Category = "Crafts",
                            DaysPerWeek = 3,
                            HobbyName = "Knitting"
                        },
                        new
                        {
                            Id = 5,
                            AnnualCost = 500,
                            Category = "Activities",
                            DaysPerWeek = 2,
                            HobbyName = "Board Games"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.TeamMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CollegeProgram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearInProgram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthdate = new DateTime(1986, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology",
                            FirstName = "Brock",
                            LastName = "Brown",
                            YearInProgram = "Sophomore"
                        },
                        new
                        {
                            Id = 2,
                            Birthdate = new DateTime(1996, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology",
                            FirstName = "Brady",
                            LastName = "Jacoby",
                            YearInProgram = "Junior"
                        },
                        new
                        {
                            Id = 3,
                            Birthdate = new DateTime(1995, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Major",
                            FirstName = "Morgan",
                            LastName = "Montgomery",
                            YearInProgram = "Grade"
                        },
                        new
                        {
                            Id = 4,
                            Birthdate = new DateTime(1991, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology",
                            FirstName = "Stephanie",
                            LastName = "McKinney",
                            YearInProgram = "Sophomore"
                        },
                        new
                        {
                            Id = 5,
                            Birthdate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Major",
                            FirstName = "Wendy",
                            LastName = "Lastname",
                            YearInProgram = "Grade"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
