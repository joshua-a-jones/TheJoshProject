namespace TheJoshProject.Api.DataAccess.Repositories;

using TheJoshProject.Api.Models;
using TheJoshProject.Api.DataAccess;

public class EmployerRepository : IEmployerRepository
{
    private readonly IRepository _repo;

    public EmployerRepository(IRepository repo)
    {
        _repo = repo;
    }

    public Task<List<Employer>> GetAllAsync()
    {
        const string sql = "SELECT * FROM Employer";
        return _repo.GetAllDataAsync<Employer>(sql, null);
    }

    public Task<Employer?> GetByIdAsync(int id)
    {
        const string sql = "SELECT * FROM Employer WHERE EmployerId = @Id";
        return _repo.GetDataAsync<Employer>(sql, new { Id = id });
    }

    public Task<int> GetIdByNameAsync(string employerName)
    {
        const string sql = "SELECT EmployerId FROM Employer WHERE EmployerName = @EmployerName";
        return _repo.GetDataAsync<int>(sql, new { EmployerName = employerName });
    }
}
