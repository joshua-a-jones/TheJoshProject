namespace TheJoshProject.Api.Models;

public class Education
{
    public int EducationId { get; set; }
    required public string SchoolName { get; set; }
    public string? SchoolLocation { get; set; }
    required public string Degree { get; set; }
    required public string Major { get; set; }
    required public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}