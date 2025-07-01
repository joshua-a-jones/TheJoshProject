using TheJoshProject.Api.Models;
namespace TheJoshProject.Api.Services;
using TheJoshProject.Api.DataAccess.Repositories;

public class EmployerService : IEmployerService
{
    private readonly IEmployerRepository _employerRepository;

    public EmployerService(IEmployerRepository employerRepository)
    {
        _employerRepository = employerRepository;
    }

    public async Task<List<Employer>> GetAllEmployers()
    {
        return await _employerRepository.GetAllAsync();
    }

    public async Task<Employer?> GetEmployer(int id)
    {
        return await _employerRepository.GetByIdAsync(id);
    }

    public async Task<int> GetEmployerIdByName(string employerName)
    {
        return await _employerRepository.GetIdByNameAsync(employerName);
    }
}