using FinalProject.Models;

namespace FinalProject.Interfaces
{
    public interface IHobbyContextDAO
    {
        Task<List<Hobby>> GetAllHobbiesAsync();
        Task<Hobby> GetHobbyByIdAsync(int id);
        Task AddHobbyAsync(Hobby hobby);
        Task UpdateHobbyAsync(Hobby hobby);
        Task DeleteHobbyAsync(int id);
    }
}
