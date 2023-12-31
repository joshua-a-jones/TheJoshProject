namespace TheJoshProject.Api.Models;
public class Skill
{
    public int Id { get; set; }
    required public string SkillName { get; set; }
    public string? SkillDescription { get; set; }
}