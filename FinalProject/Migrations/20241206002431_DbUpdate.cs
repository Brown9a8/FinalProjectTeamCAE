using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class DbUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FavoriteFoods",
                columns: new[] { "Id", "Calories", "FoodName", "IsVegetarian", "MealOfDay" },
                values: new object[] { 1, 400, "Steak", false, "Any" });

            migrationBuilder.InsertData(
                table: "FavoriteRides",
                columns: new[] { "Id", "Location", "MinRiderHeight", "RideName", "RideType" },
                values: new object[] { 1, "CedarPoint", 52, "Raptor", "rollercoaster" });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "AnnualCost", "Category", "DaysPerWeek", "HobbyName" },
                values: new object[] { 1, 100, "Coins", 1, "Collecting" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FirstName", "LastName", "YearInProgram" },
                values: new object[] { 1, "10/19/1986", "Information Technology", "Brock", "Brown", "Sophmore" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FavoriteFoods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FavoriteRides",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
