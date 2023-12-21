using TheJoshProject.Api.Models;
namespace TheJoshProject.Api.Services;

public interface IEducationService
{
    Task<List<Education>> GetAllEducationAsync();
    Task<Education?> GetEducationByIdAsync(int id);
}