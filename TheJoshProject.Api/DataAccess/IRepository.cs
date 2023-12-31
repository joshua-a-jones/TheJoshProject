namespace TheJoshProject.Api.DataAccess;

public interface IRepository : IDisposable
{
    Task<T?> GetDataAsync<T>(string command, object? parms); 
    Task<List<T>> GetAllDataAsync<T>(string command, object? parms );
    Task<int> EditDataAsync(string command, object parms);

}