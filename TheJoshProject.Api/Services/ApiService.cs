namespace TheJoshProject.Api.Services;

public abstract class ApiService
{
    protected readonly IDbService _dbService;

    protected ApiService(IDbService dbService)
    {
        _dbService = dbService;
    }
}