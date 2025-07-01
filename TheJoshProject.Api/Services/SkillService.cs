using TheJoshProject.Api.DataAccess.Repositories;
using TheJoshProject.Api.Models;
namespace TheJoshProject.Api.Services;

public class SkillService : ISkillService
{
    private readonly ISkillRepository _skillRepository;

    public SkillService(ISkillRepository skillRepository)
    {
        _skillRepository = skillRepository;
    }

    public async Task<List<Skill>> GetAllSkills()
    {
        return await _skillRepository.GetAllAsync();
    }

    public async Task<List<Skill>> GetSkillsByExperienceId(int experienceId)
    {
        return await _skillRepository.GetByExperienceIdAsync(experienceId);
    }

    public async Task<List<Skill>> GetSkillsByEmployerAndJob(string employerName, string jobTitle)
    {
        return await _skillRepository.GetByEmployerAndJobAsync(employerName, jobTitle);
    }
    public async Task<Skill?> GetSkill(int id)
    {
        return await _skillRepository.GetByIdAsync(id);
    }
}