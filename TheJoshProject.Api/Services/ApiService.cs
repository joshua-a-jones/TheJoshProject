using TheJoshProject.Api.DataAccess;

namespace TheJoshProject.Api.Services;

public abstract class ApiService : IDisposable
{
    protected readonly IRepository _repo;

    protected ApiService(IRepository repo)
    {
        _repo = repo;
    }

    public void Dispose()
    {
        _repo.Dispose();
    }
}