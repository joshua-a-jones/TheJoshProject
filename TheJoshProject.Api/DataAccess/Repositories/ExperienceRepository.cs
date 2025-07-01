namespace TheJoshProject.Api.DataAccess.Repositories;

using TheJoshProject.Api.Models;
using TheJoshProject.Api.DataAccess;

public class ExperienceRepository : IExperienceRepository
{
    private readonly IRepository _repo;

    public ExperienceRepository(IRepository repo)
    {
        _repo = repo;
    }

    public Task<List<Experience>> GetAllAsync()
    {
        const string sql = @"            
            SELECT em.EmployerName, ex.* FROM Experience ex
            JOIN Employer em ON em.EmployerId = ex.EmployerId";
        return _repo.GetAllDataAsync<Experience>(sql, null);
    }

    public Task<Experience?> GetByIdAsync(int id)
    {
        const string sql = @"            
            SELECT em.EmployerName, ex.* FROM Experience ex
            JOIN Employer em ON em.EmployerId = ex.EmployerId
            WHERE ex.ExperienceId = @Id";
        return _repo.GetDataAsync<Experience>(sql, new { Id = id });
    }

    public Task<int> GetIdByEmployerAndJobAsync(string employerName, string jobTitle)
    {
        const string sql = @"            
            SELECT ex.ExperienceId FROM Experience ex
            JOIN Employer em ON em.EmployerId = ex.EmployerId
            WHERE em.EmployerName = @EmployerName AND ex.JobTitle = @JobTitle";
        return _repo.GetDataAsync<int>(sql, new { EmployerName = employerName, JobTitle = jobTitle });
    }
}
