namespace TheJoshProject.Api.Models;

public class Employer
{
    public int Id { get; set; }
    required public string EmployerName { get; set; }
    public string? EmployerDescription { get; set; }
}