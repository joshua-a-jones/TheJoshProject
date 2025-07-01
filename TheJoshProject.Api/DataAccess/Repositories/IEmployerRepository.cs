namespace TheJoshProject.Api.DataAccess.Repositories;

using TheJoshProject.Api.Models;

public interface IEmployerRepository
{
    Task<List<Employer>> GetAllAsync();
    Task<Employer?> GetByIdAsync(int id);
    Task<int> GetIdByNameAsync(string employerName);
}
