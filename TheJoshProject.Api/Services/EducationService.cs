using TheJoshProject.Api.DataAccess.Repositories;
using TheJoshProject.Api.Models;

namespace TheJoshProject.Api.Services;

public class EducationService : IEducationService
{
    private readonly IEducationRepository _educationRepository;

    public EducationService(IEducationRepository educationRepository)
    {
        _educationRepository = educationRepository;
    }

    public async Task<List<Education>> GetAllEducationAsync()
    {
        return await _educationRepository.GetAllAsync();
    }

    public async Task<Education?> GetEducationByIdAsync(int id)
    {
        return await _educationRepository.GetByIdAsync(id);
    }
}