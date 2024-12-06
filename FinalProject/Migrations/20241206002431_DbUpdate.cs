using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations {
    public partial class DbUpdate : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.InsertData(
                table: "FavoriteFoods",
                columns: new[] { "Id", "Calories", "FoodName", "IsVegetarian", "MealOfDay" },
                values: new object[,] {
                    { 1, 400, "Steak", false, "Any" },
                    { 2, 320, "Mac n' Cheese", true, "Lunch" },
                    { 3, 460, "Ice Cream", true, "Dessert" },
                    { 4, 380, "Pepperoni Pizza", false, "Dinner" },
                    { 5, 280, "Cereal", true, "Breakfast" }
                }
            );

            migrationBuilder.InsertData(
                table: "FavoriteRides",
                columns: new[] { "Id", "Location", "MinRiderHeight", "RideName", "RideType" },
                values: new object[,] {
                    { 1, "Cedar Point", 52, "Raptor", "Roller Coaster" },
                    { 2, "Cedar Point", 52, "Top Thrill Dragster", "Roller Coaster"},
                    { 3, "Kings Island", 48, "The Beast", "Roller Coaster" },
                    { 4, "Hershey Park", 42, "Storm Runner", "Roller Coaster" },
                    { 5, "Disney World", 40, "Space Mountain", "Thriller" }
                }
            );

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "AnnualCost", "Category", "DaysPerWeek", "HobbyName" },
                values: new object[,] {
                    { 1, 100, "Coins", 1, "Collecting" },
                    { 2, 950, "Sports", 2, "Mountain Biking" },
                    { 3, 500, "Sports", 3, "Volleyball" },
                    { 4, 500, "Activities", 2, "Hobby 4" },
                    { 5, 500, "Activities", 2, "Hobby 5" }
                }
            );

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FirstName", "LastName", "YearInProgram" },
                values: new object[,] {
                    { 1, "10/19/1986", "Information Technology", "Brock", "Brown", "Sophomore" },
                    { 2, "07/04/1996", "Information Technology", "Brady", "Jacoby", "Junior" },
                    { 3, "01/01/2000", "Major", "Morgan", "Lastname", "Grade" },
                    { 4, "02/17/1991", "Information Technology", "Stephanie", "McKinney", "Sophomore" },
                    { 5, "01/01/2000", "Major", "Wendy", "Lastname", "Grade" }
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            var ids = new[] { 1, 2, 3, 4, 5 };
            foreach (var id in ids) {
                migrationBuilder.DeleteData(table: "FavoriteFoods", keyColumn: "Id", keyValue: id);
                migrationBuilder.DeleteData(table: "FavoriteRides", keyColumn: "Id", keyValue: id);
                migrationBuilder.DeleteData(table: "Hobbies", keyColumn: "Id", keyValue: id);
                migrationBuilder.DeleteData(table: "Members", keyColumn: "Id", keyValue: id);
            }
        }
    }
}
/*            migrationBuilder.DeleteData(
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

                
            migrationBuilder.DeleteData(
                table: "FavoriteFoods",
                keyColumn: "Id",
                keyValue: 2);
            migrationBuilder.DeleteData(
                table: "FavoriteRides",
                keyColumn: "Id",
                keyValue: 2);
            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 2);
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2);


             migrationBuilder.DeleteData(
                table: "FavoriteFoods",
                keyColumn: "Id",
                keyValue: 3);
            migrationBuilder.DeleteData(
                table: "FavoriteRides",
                keyColumn: "Id",
                keyValue: 3);
            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 3);
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3);

             migrationBuilder.DeleteData(
                table: "FavoriteFoods",
                keyColumn: "Id",
                keyValue: 4);
            migrationBuilder.DeleteData(
                table: "FavoriteRides",
                keyColumn: "Id",
                keyValue: 4);
            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 4);
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4);
*/
