namespace TheJoshProject.Api.Models;

public class Employer
{
    public int EmployerId { get; set; }
    required public string EmployerName { get; set; }
    public string? EmployerDescription { get; set; }
}