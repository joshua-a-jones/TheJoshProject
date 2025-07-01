namespace TheJoshProject.Api.DataAccess.Repositories;

using TheJoshProject.Api.Models;

public interface IExperienceRepository
{
    Task<List<Experience>> GetAllAsync();
    Task<Experience?> GetByIdAsync(int id);
    Task<int> GetIdByEmployerAndJobAsync(string employerName, string jobTitle);
}
