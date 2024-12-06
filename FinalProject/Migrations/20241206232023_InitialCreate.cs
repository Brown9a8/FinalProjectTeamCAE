using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MealOfDay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    IsVegetarian = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteFoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteRides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RideName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RideType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinRiderHeight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteRides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnnualCost = table.Column<int>(type: "int", nullable: false),
                    DaysPerWeek = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CollegeProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearInProgram = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavoriteFoods",
                columns: new[] { "Id", "Calories", "FoodName", "IsVegetarian", "MealOfDay" },
                values: new object[,]
                {
                    { 1, 400, "Steak", false, "Any" },
                    { 2, 320, "Mac n' Cheese", true, "Lunch" },
                    { 3, 460, "Ice Cream", true, "Dessert" },
                    { 4, 380, "Pepperoni Pizza", false, "Dinner" },
                    { 5, 280, "Cereal", true, "Breakfast" }
                });

            migrationBuilder.InsertData(
                table: "FavoriteRides",
                columns: new[] { "Id", "Location", "MinRiderHeight", "RideName", "RideType" },
                values: new object[,]
                {
                    { 1, "Cedar Point", 52, "Raptor", "Roller Coaster" },
                    { 2, "Cedar Point", 52, "Top Thrill Dragster", "Roller Coaster" },
                    { 3, "Kings Island", 48, "The Beast", "Roller Coaster" },
                    { 4, "Hershey Park", 42, "Storm Runner", "Roller Coaster" },
                    { 5, "Disney World", 40, "Space Mountain", "Thriller" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "AnnualCost", "Category", "DaysPerWeek", "HobbyName" },
                values: new object[,]
                {
                    { 1, 100, "Coins", 1, "Collecting" },
                    { 2, 950, "Sports", 2, "Mountain Biking" },
                    { 3, 500, "Sports", 3, "Volleyball" },
                    { 4, 1000, "Crafts", 3, "Knitting" },
                    { 5, 500, "Activities", 2, "Board Games" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FirstName", "LastName", "YearInProgram" },
                values: new object[,]
                {
                    { 1, new DateTime(1986, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Brock", "Brown", "Sophomore" },
                    { 2, new DateTime(1996, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Brady", "Jacoby", "Junior" },
                    { 3, new DateTime(1995, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Major", "Morgan", "Montgomery", "Grade" },
                    { 4, new DateTime(1991, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Stephanie", "McKinney", "Sophomore" },
                    { 5, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Major", "Wendy", "Lastname", "Grade" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteFoods");

            migrationBuilder.DropTable(
                name: "FavoriteRides");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
