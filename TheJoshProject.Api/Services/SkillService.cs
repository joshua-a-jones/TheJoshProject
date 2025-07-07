using TheJoshProject.Api.DataAccess.Repositories;
using TheJoshProject.Api.Models;
namespace TheJoshProject.Api.Services;
using Microsoft.Extensions.Logging;

public class SkillService : ISkillService
{
    private readonly ISkillRepository _skillRepository;
    private readonly ILogger<SkillService> _logger;

    public SkillService(ISkillRepository skillRepository, ILogger<SkillService> logger)
    {
        _skillRepository = skillRepository;
        _logger = logger;
    }

    public async Task<List<Skill>> GetAllSkills()
    {
        _logger.LogInformation("Retrieving all skills");
        return await _skillRepository.GetAllAsync();
    }

    public async Task<List<Skill>> GetSkillsByExperienceId(int experienceId)
    {
        _logger.LogInformation("Retrieving skills for experience {ExperienceId}", experienceId);
        return await _skillRepository.GetByExperienceIdAsync(experienceId);
    }

    public async Task<List<Skill>> GetSkillsByEmployerAndJob(string employerName, string jobTitle)
    {
        _logger.LogInformation("Retrieving skills for employer {Employer} and job {Job}", employerName, jobTitle);
        return await _skillRepository.GetByEmployerAndJobAsync(employerName, jobTitle);
    }
    public async Task<Skill?> GetSkill(int id)
    {
        _logger.LogInformation("Retrieving skill with id {Id}", id);
        return await _skillRepository.GetByIdAsync(id);
    }
}