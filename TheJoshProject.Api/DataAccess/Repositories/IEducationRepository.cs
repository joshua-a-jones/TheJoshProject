namespace TheJoshProject.Api.DataAccess.Repositories;

using TheJoshProject.Api.Models;

public interface IEducationRepository
{
    Task<List<Education>> GetAllAsync();
    Task<Education?> GetByIdAsync(int id);
}
