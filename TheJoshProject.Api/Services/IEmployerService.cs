using TheJoshProject.Api.Models;
namespace TheJoshProject.Api.Services;

public interface IEmployerService
{
    Task<List<Employer>> GetAllEmployers();
    Task<Employer?> GetEmployer(int id);
    Task<int> GetEmployerIdByName(string employerName);
}