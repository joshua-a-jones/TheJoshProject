using TheJoshProject.Api.Models;
namespace TheJoshProject.Api.Services;

public class SkillService : ISkillService
{
    private readonly IDbService _dbService;
    public SkillService(IDbService dbService)
    {
        _dbService = dbService;
    }

    public async Task<List<Skill>> GetAllSkills()
    {
        return await _dbService.GetAll<Skill>("SELECT * FROM Skill", null);
    }

    public async Task<List<Skill>> GetSkillsByExperienceId(int experienceId)
    {
        var sql = @"
            SELECT s.SkillName, s.SkillDescription FROM Skill s
            JOIN ExperienceSkill es ON es.SkillId = s.SkillId
            JOIN Experience ex ON ex.ExperienceId = es.ExperienceId
            JOIN Employer em ON em.EmployerId = ex.EmployerId
            WHERE ex.ExperienceId = @Id";

        return await _dbService.GetAll<Skill>(sql, new { Id = experienceId });
    }

    public async Task<List<Skill>> GetSkillsByEmployerAndJob(string employerName, string jobTitle)
    {
        var sql = @"
            SELECT s.SkillName, s.SkillDescription FROM Skill s
            JOIN ExperienceSkill es ON es.SkillId = s.SkillId
            JOIN Experience ex ON ex.ExperienceId = es.ExperienceId
            JOIN Employer em ON em.EmployerId = ex.EmployerId
            WHERE em.EmployerName = @EmployerName AND ex.JobTitle = @JobTitle";

        return await _dbService.GetAll<Skill>(sql, new { EmployerName = employerName, JobTitle = jobTitle });
    }
    public async Task<Skill?> GetSkill(int id)
    {
        return await _dbService.GetAsync<Skill>("SELECT * FROM Skill WHERE SkillId = @Id", new { Id = id });
    }
}