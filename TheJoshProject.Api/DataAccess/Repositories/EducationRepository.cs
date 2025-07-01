namespace TheJoshProject.Api.DataAccess.Repositories;

using TheJoshProject.Api.Models;
using TheJoshProject.Api.DataAccess;

public class EducationRepository : IEducationRepository
{
    private readonly IRepository _repo;

    public EducationRepository(IRepository repo)
    {
        _repo = repo;
    }

    public Task<List<Education>> GetAllAsync()
    {
        const string sql = "SELECT * FROM Education";
        return _repo.GetAllDataAsync<Education>(sql, null);
    }

    public Task<Education?> GetByIdAsync(int id)
    {
        const string sql = "SELECT * FROM Education WHERE EducationId = @Id";
        return _repo.GetDataAsync<Education>(sql, new { Id = id });
    }
}
