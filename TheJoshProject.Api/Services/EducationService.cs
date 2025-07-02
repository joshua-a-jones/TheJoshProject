using TheJoshProject.Api.DataAccess.Repositories;
using TheJoshProject.Api.Models;
using Microsoft.Extensions.Logging;

namespace TheJoshProject.Api.Services;

public class EducationService : IEducationService
{
    private readonly IEducationRepository _educationRepository;
    private readonly ILogger<EducationService> _logger;

    public EducationService(IEducationRepository educationRepository, ILogger<EducationService> logger)
    {
        _educationRepository = educationRepository;
        _logger = logger;
    }

    public async Task<List<Education>> GetAllEducationAsync()
    {
        _logger.LogInformation("Retrieving all education records");
        return await _educationRepository.GetAllAsync();
    }

    public async Task<Education?> GetEducationByIdAsync(int id)
    {
        _logger.LogInformation("Retrieving education with id {Id}", id);
        return await _educationRepository.GetByIdAsync(id);
    }
}