namespace TheJoshProject.Api.Models;
public class Skill
{
    public int SkillId { get; set; }
    required public string SkillName { get; set; }
    public string? SkillDescription { get; set; }
}