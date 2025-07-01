namespace TheJoshProject.Api.DataAccess.Repositories;

using TheJoshProject.Api.Models;
using TheJoshProject.Api.DataAccess;

public class SkillRepository : ISkillRepository
{
    private readonly IRepository _repo;

    public SkillRepository(IRepository repo)
    {
        _repo = repo;
    }

    public Task<List<Skill>> GetAllAsync()
    {
        const string sql = "SELECT * FROM Skill";
        return _repo.GetAllDataAsync<Skill>(sql, null);
    }

    public Task<List<Skill>> GetByExperienceIdAsync(int experienceId)
    {
        const string sql = @"            
            SELECT s.SkillId, s.SkillName, s.SkillDescription FROM Skill s
            JOIN ExperienceSkill es ON es.SkillId = s.SkillId
            JOIN Experience ex ON ex.ExperienceId = es.ExperienceId
            JOIN Employer em ON em.EmployerId = ex.EmployerId
            WHERE ex.ExperienceId = @Id";
        return _repo.GetAllDataAsync<Skill>(sql, new { Id = experienceId });
    }

    public Task<List<Skill>> GetByEmployerAndJobAsync(string employerName, string jobTitle)
    {
        const string sql = @"            
            SELECT s.SkillId, s.SkillName, s.SkillDescription FROM Skill s
            JOIN ExperienceSkill es ON es.SkillId = s.SkillId
            JOIN Experience ex ON ex.ExperienceId = es.ExperienceId
            JOIN Employer em ON em.EmployerId = ex.EmployerId
            WHERE em.EmployerName = @EmployerName AND ex.JobTitle = @JobTitle";
        return _repo.GetAllDataAsync<Skill>(sql, new { EmployerName = employerName, JobTitle = jobTitle });
    }

    public Task<Skill?> GetByIdAsync(int id)
    {
        const string sql = "SELECT * FROM Skill WHERE SkillId = @Id";
        return _repo.GetDataAsync<Skill>(sql, new { Id = id });
    }
}
