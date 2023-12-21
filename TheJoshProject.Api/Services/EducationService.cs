using TheJoshProject.Api.Models;

namespace TheJoshProject.Api.Services;

public class EducationService : ApiService, IEducationService
{
    public EducationService(IDbService dbService) : base(dbService)
    {
    }

    public async Task<List<Education>> GetAllEducationAsync()
    {
        var sql = "SELECT * FROM Education";
        return await _dbService.GetAll<Education>(sql, null);
    }

    public async Task<Education?> GetEducationByIdAsync(int id)
    {
        var sql = "SELECT * FROM Education WHERE EducationId = @Id";
        return await _dbService.GetAsync<Education>(sql, new { Id = id });
    }
}