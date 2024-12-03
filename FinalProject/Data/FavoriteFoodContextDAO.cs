using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class FavoriteFoodContextDAO : IFavoriteFoodContextDAO
    {
        private readonly ProjectDbContext _context;

        public FavoriteFoodContextDAO(ProjectDbContext context)
        {
            _context = context;
        }
            // Get all favorite foods
            public async Task<List<FavoriteFood>> GetAllFavoriteFoodsAsync()
            {
                return await _context.FavoriteFoods.ToListAsync();
            }

            // Get a favorite food by Id
            public async Task<FavoriteFood> GetFavoriteFoodByIdAsync(int id)
            {
                return await _context.FavoriteFoods.FindAsync(id);
            }

            // Add a new favorite food
            public async Task AddFavoriteFoodAsync(FavoriteFood favoriteFood)
            {
                _context.FavoriteFoods.Add(favoriteFood);
                await _context.SaveChangesAsync();
            }

            // Update an existing favorite food
            public async Task UpdateFavoriteFoodAsync(FavoriteFood favoriteFood)
            {
                _context.FavoriteFoods.Update(favoriteFood);
                await _context.SaveChangesAsync();
            }

            // Delete a favorite food by Id
            public async Task DeleteFavoriteFoodAsync(int id)
            {
                var favoriteFood = await _context.FavoriteFoods.FindAsync(id);
                if (favoriteFood != null)
                {
                    _context.FavoriteFoods.Remove(favoriteFood);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }

