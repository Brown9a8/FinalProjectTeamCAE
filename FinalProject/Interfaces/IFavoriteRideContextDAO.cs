using FinalProject.Models;

namespace FinalProject.Interfaces
{
    public interface IFavoriteRideContextDAO
    {
        Task<List<FavoriteRide>> GetAllFavoriteRidesAsync();
        Task<FavoriteRide> GetFavoriteRideByIdAsync(int id);
        Task AddFavoriteRideAsync(FavoriteRide favoriteRide);
        Task UpdateFavoriteRideAsync(FavoriteRide favoriteRide);
        Task DeleteFavoriteRideAsync(int id);
    }
}

