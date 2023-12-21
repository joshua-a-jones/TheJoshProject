namespace TheJoshProject.Api.Models;

public class Experience {
    required public string EmployerName { get; set; }
    required public string JobTitle { get; set; }
    public string? JobDescription { get; set; }
    required public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}