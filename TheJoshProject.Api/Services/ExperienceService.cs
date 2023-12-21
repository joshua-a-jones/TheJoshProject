using TheJoshProject.Api.Models;

namespace TheJoshProject.Api.Services;

public class ExperienceService : IExperienceService
{
    private readonly IDbService _dbService;

    public ExperienceService(IDbService dbService)
    {
        _dbService = dbService;
    }

    public async Task<List<Experience>> GetAllExperience()
    {
        List<Experience> result;

        var sql = @"
            SELECT em.EmployerName, ex.* FROM Experience ex
            JOIN Employer em ON em.EmployerId = ex.EmployerId";

        result = await _dbService.GetAll<Experience>(sql, null);

        return result;
    }

    public async Task<Experience?> GetExperience(int id)
    {
        var sql = @"
            SELECT em.EmployerName, ex.* FROM Experience ex
            JOIN Employer em ON em.EmployerId = ex.EmployerId
            WHERE ex.ExperienceId = @Id";

        return await _dbService.GetAsync<Experience>(sql, new { Id = id });
    }

    public async Task<int> GetExperienceIdByEmployerAndJob(string employerName, string jobTitle)
    {
        var sql = @"
            SELECT ex.ExperienceId FROM Experience ex
            JOIN Employer em ON em.EmployerId = ex.EmployerId
            WHERE em.EmployerName = @EmployerName AND ex.JobTitle = @JobTitle";

        return await _dbService.GetAsync<int>(sql, new { EmployerName = employerName, JobTitle = jobTitle });
    }

}