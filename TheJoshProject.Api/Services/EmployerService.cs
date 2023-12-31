using TheJoshProject.Api.Models;
namespace TheJoshProject.Api.Services;
using TheJoshProject.Api.DataAccess;

public class EmployerService : ApiService, IEmployerService
{
    public EmployerService(IRepository repo) : base(repo)
    {
    }

    public async Task<List<Employer>> GetAllEmployers()
    {
        var sql = @"
            SELECT * FROM Employer
        ";

        return await _repo.GetAllDataAsync<Employer>(sql, null);
    }

    public async Task<Employer?> GetEmployer(int id)
    {
        var sql = @"
            SELECT * FROM Employer WHERE EmployerId = @Id
        ";

        return await _repo.GetDataAsync<Employer>(sql, new { Id = id });
    }

    public async Task<int> GetEmployerIdByName(string employerName)
    {
        var sql = @"
            SELECT EmployerId FROM Employer WHERE EmployerName = @EmployerName
        ";

        return await _repo.GetDataAsync<int>(sql, new { EmployerName = employerName });
    }
}