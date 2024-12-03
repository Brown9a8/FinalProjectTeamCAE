using FinalProject.Models;
using FinalProject.Data;
using FinalProject.Controllers;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Interfaces
{
    public interface ITeamMembersContextDAO
    {
        Task<List<TeamMember>> GetAllTeamMembersAsync();
        Task<TeamMember> GetTeamMemberByIdAsync(int id);
        Task AddTeamMemberAsync(TeamMember member);
        Task UpdateTeamMemberAsync(TeamMember member);
        Task DeleteTeamMemberAsync(int id);
    }
}
