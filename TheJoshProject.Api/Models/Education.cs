namespace TheJoshProject.Api.Models;

public class Education
{
    required public string SchoolName { get; set; }
    required public string Degree { get; set; }
    required public string Major { get; set; }
    required public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}