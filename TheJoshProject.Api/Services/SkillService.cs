using TheJoshProject.Api.DataAccess;
using TheJoshProject.Api.Models;
namespace TheJoshProject.Api.Services;

public class SkillService : ApiService, ISkillService
{
    public SkillService(IRepository repo) : base(repo)
    {
    }

    public async Task<List<Skill>> GetAllSkills()
    {
        return await _repo.GetAllDataAsync<Skill>("SELECT * FROM Skill", null);
    }

    public async Task<List<Skill>> GetSkillsByExperienceId(int experienceId)
    {
        var sql = @"
            SELECT s.SkillName, s.SkillDescription FROM Skill s
            JOIN ExperienceSkill es ON es.SkillId = s.SkillId
            JOIN Experience ex ON ex.ExperienceId = es.ExperienceId
            JOIN Employer em ON em.EmployerId = ex.EmployerId
            WHERE ex.ExperienceId = @Id";

        return await _repo.GetAllDataAsync<Skill>(sql, new { Id = experienceId });
    }

    public async Task<List<Skill>> GetSkillsByEmployerAndJob(string employerName, string jobTitle)
    {
        var sql = @"
            SELECT s.SkillName, s.SkillDescription FROM Skill s
            JOIN ExperienceSkill es ON es.SkillId = s.SkillId
            JOIN Experience ex ON ex.ExperienceId = es.ExperienceId
            JOIN Employer em ON em.EmployerId = ex.EmployerId
            WHERE em.EmployerName = @EmployerName AND ex.JobTitle = @JobTitle";

        return await _repo.GetAllDataAsync<Skill>(sql, new { EmployerName = employerName, JobTitle = jobTitle });
    }
    public async Task<Skill?> GetSkill(int id)
    {
        return await _repo.GetDataAsync<Skill>("SELECT * FROM Skill WHERE SkillId = @Id", new { Id = id });
    }
}