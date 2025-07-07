using TheJoshProject.Api.Models;
namespace TheJoshProject.Api.Services;
using TheJoshProject.Api.DataAccess.Repositories;
using Microsoft.Extensions.Logging;

public class EmployerService : IEmployerService
{
    private readonly IEmployerRepository _employerRepository;
    private readonly ILogger<EmployerService> _logger;

    public EmployerService(IEmployerRepository employerRepository, ILogger<EmployerService> logger)
    {
        _employerRepository = employerRepository;
        _logger = logger;
    }

    public async Task<List<Employer>> GetAllEmployers()
    {
        _logger.LogInformation("Retrieving all employers");
        return await _employerRepository.GetAllAsync();
    }

    public async Task<Employer?> GetEmployer(int id)
    {
        _logger.LogInformation("Retrieving employer with id {EmployerId}", id);
        return await _employerRepository.GetByIdAsync(id);
    }

    public async Task<int> GetEmployerIdByName(string employerName)
    {
        _logger.LogInformation("Retrieving employer id for {Name}", employerName);
        return await _employerRepository.GetIdByNameAsync(employerName);
    }
}