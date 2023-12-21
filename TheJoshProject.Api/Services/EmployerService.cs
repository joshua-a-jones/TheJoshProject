using TheJoshProject.Api.Models;
namespace TheJoshProject.Api.Services;

public class EmployerService : ApiService, IEmployerService
{
    public EmployerService(IDbService dbService) : base(dbService)
    {
    }

    public async Task<List<Employer>> GetAllEmployers()
    {
        var sql = @"
            SELECT * FROM Employer
        ";

        return await _dbService.GetAll<Employer>(sql, null);
    }

    public async Task<Employer?> GetEmployer(int id)
    {
        var sql = @"
            SELECT * FROM Employer WHERE EmployerId = @Id
        ";

        return await _dbService.GetAsync<Employer>(sql, new { Id = id });
    }

    public async Task<int> GetEmployerIdByName(string employerName)
    {
        var sql = @"
            SELECT EmployerId FROM Employer WHERE EmployerName = @EmployerName
        ";

        return await _dbService.GetAsync<int>(sql, new { EmployerName = employerName });
    }
}