using TheJoshProject.Api.DataAccess.Repositories;
using TheJoshProject.Api.Models;
using Microsoft.Extensions.Logging;

namespace TheJoshProject.Api.Services;

public class ExperienceService : IExperienceService
{
    private readonly IExperienceRepository _experienceRepository;
    private readonly ILogger<ExperienceService> _logger;

    public ExperienceService(IExperienceRepository experienceRepository, ILogger<ExperienceService> logger)
    {
        _experienceRepository = experienceRepository;
        _logger = logger;
    }

    public async Task<List<Experience>> GetAllExperience()
    {
        _logger.LogInformation("Retrieving all experiences");
        return await _experienceRepository.GetAllAsync();
    }

    public async Task<Experience?> GetExperience(int id)
    {
        _logger.LogInformation("Retrieving experience with id {Id}", id);
        return await _experienceRepository.GetByIdAsync(id);
    }

    public async Task<int> GetExperienceIdByEmployerAndJob(string employerName, string jobTitle)
    {
        _logger.LogInformation(
            "Retrieving experience id for employer {EmployerName} and job {JobTitle}",
            employerName,
            jobTitle);
        return await _experienceRepository.GetIdByEmployerAndJobAsync(employerName, jobTitle);
    }

}