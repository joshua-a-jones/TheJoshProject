using TheJoshProject.Api.Models;

namespace TheJoshProject.Api.Services;
public interface IExperienceService
{
    Task<List<Experience>> GetAllExperience();
    Task<Experience?> GetExperience(int id);
    Task<int> GetExperienceIdByEmployerAndJob(string employerName, string jobTitle);
}