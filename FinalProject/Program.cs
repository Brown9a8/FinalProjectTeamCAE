using FinalProject.Data;
using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProjectDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProjectDbContext")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ITeamMembersContextDAO, TeamMembersContextDAO>();
builder.Services.AddScoped<IHobbyContextDAO, HobbyContextDAO>();
builder.Services.AddScoped<IFavoriteRideContextDAO, FavoriteRideContextDAO>();
builder.Services.AddScoped<IFavoriteFoodContextDAO, FavoriteFoodContextDAO>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ProjectDbContext>();
    var dao1 = services.GetRequiredService<ITeamMembersContextDAO>();
    var dao2 = services.GetRequiredService<IHobbyContextDAO>();
    var dao3 = services.GetRequiredService<IFavoriteRideContextDAO>();
    var dao4 = services.GetRequiredService<IFavoriteFoodContextDAO>();

    // Ensure database is created
      context.Database.Migrate();

    // Building the inital tables
    if (!context.Members.Any())
    {
        var newMember1 = new TeamMember { Id = 1, FirstName = "Brock", LastName = "Brown", Birthdate = "10/19/1986", CollegeProgram = "Information Technology", YearInProgram = "Sophmore" };
        await dao1.AddTeamMemberAsync(newMember1);

        var newHobby1 = new Hobby { Id = 1, HobbyName = "Collecting", Category = "Coins", AnnualCost = 100, DaysPerWeek = 1 };
        await dao2.AddHobbyAsync(newHobby1);

        var newFavoriteRide1 = new FavoriteRide { Id = 1, Location = "CedarPoint", RideName = "Raptor", RideType = "rollercoaster", MinRiderHeight = 52 };
        await dao3.AddFavoriteRideAsync(newFavoriteRide1);

        var newFavoriteFood1 = new FavoriteFood { Id = 1, FoodName = "Steak", MealOfDay = "Any", Calories = 400, IsVegetarian = false };
        await dao4.AddFavoriteFoodAsync(newFavoriteFood1);
    }
}

app.Run();

