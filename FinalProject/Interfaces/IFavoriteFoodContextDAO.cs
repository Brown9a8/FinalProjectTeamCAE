using FinalProject.Models;

namespace FinalProject.Interfaces
{
    public interface IFavoriteFoodContextDAO
    {
        Task<List<FavoriteFood>> GetAllFavoriteFoodsAsync();
        Task<FavoriteFood> GetFavoriteFoodByIdAsync(int id);
        Task AddFavoriteFoodAsync(FavoriteFood favoriteFood);
        Task UpdateFavoriteFoodAsync(FavoriteFood favoriteFood);
        Task DeleteFavoriteFoodAsync(int id);
    }
}
