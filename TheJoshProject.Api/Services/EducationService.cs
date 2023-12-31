using TheJoshProject.Api.DataAccess;
using TheJoshProject.Api.Models;

namespace TheJoshProject.Api.Services;

public class EducationService : ApiService, IEducationService
{
    public EducationService(IRepository repo) : base(repo)
    {
    }

    public async Task<List<Education>> GetAllEducationAsync()
    {
        var sql = "SELECT * FROM Education";
        return await _repo.GetAllDataAsync<Education>(sql, null);
    }

    public async Task<Education?> GetEducationByIdAsync(int id)
    {
        var sql = "SELECT * FROM Education WHERE EducationId = @Id";
        return await _repo.GetDataAsync<Education>(sql, new { Id = id });
    }
}