namespace TheJoshProject.Api.DataAccess.Repositories;

using TheJoshProject.Api.Models;
using TheJoshProject.Api.DataAccess;
using Dapper;

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

    public Task<List<Experience>> GetFilteredAsync(string? employerName, DateTime? startDate, DateTime? endDate)
    {
        var sql = @"
            SELECT em.EmployerName, ex.* FROM Experience ex
            JOIN Employer em ON em.EmployerId = ex.EmployerId";

        var clauses = new List<string>();
        var parms = new Dapper.DynamicParameters();

        if (!string.IsNullOrWhiteSpace(employerName))
        {
            clauses.Add("em.EmployerName = @EmployerName");
            parms.Add("EmployerName", employerName);
        }
        if (startDate.HasValue)
        {
            clauses.Add("ex.StartDate >= @StartDate");
            parms.Add("StartDate", startDate.Value);
        }
        if (endDate.HasValue)
        {
            clauses.Add("(ex.EndDate <= @EndDate OR ex.EndDate IS NULL AND ex.StartDate <= @EndDate)");
            parms.Add("EndDate", endDate.Value);
        }

        if (clauses.Count > 0)
        {
            sql += " WHERE " + string.Join(" AND ", clauses);
        }

        return _repo.GetAllDataAsync<Experience>(sql, parms);
    }
}
