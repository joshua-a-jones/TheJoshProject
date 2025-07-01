namespace TheJoshProject.Api.DataAccess.Repositories;

using TheJoshProject.Api.Models;

public interface ISkillRepository
{
    Task<List<Skill>> GetAllAsync();
    Task<List<Skill>> GetByExperienceIdAsync(int experienceId);
    Task<List<Skill>> GetByEmployerAndJobAsync(string employerName, string jobTitle);
    Task<Skill?> GetByIdAsync(int id);
}
