using TheJoshProject.Api.DataAccess.Repositories;
using TheJoshProject.Api.Models;

namespace TheJoshProject.Api.Services;

public class ExperienceService : IExperienceService
{
    private readonly IExperienceRepository _experienceRepository;

    public ExperienceService(IExperienceRepository experienceRepository)
    {
        _experienceRepository = experienceRepository;
    }

    public async Task<List<Experience>> GetAllExperience()
    {
        return await _experienceRepository.GetAllAsync();
    }

    public async Task<Experience?> GetExperience(int id)
    {
        return await _experienceRepository.GetByIdAsync(id);
    }

    public async Task<int> GetExperienceIdByEmployerAndJob(string employerName, string jobTitle)
    {
        return await _experienceRepository.GetIdByEmployerAndJobAsync(employerName, jobTitle);
    }

    public async Task<List<Experience>> GetExperienceByFilters(string? employerName, DateTime? startDate, DateTime? endDate)
    {
        return await _experienceRepository.GetFilteredAsync(employerName, startDate, endDate);
    }

}