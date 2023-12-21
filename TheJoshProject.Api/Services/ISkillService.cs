using TheJoshProject.Api.Models;
namespace TheJoshProject.Api.Services;
public interface ISkillService
{
    Task<List<Skill>> GetAllSkills();
    Task<List<Skill>>GetSkillsByExperienceId(int experienceId);
    Task<List<Skill>>GetSkillsByEmployerAndJob(string employerName, string jobTitle);
    Task<Skill?> GetSkill(int id);
}