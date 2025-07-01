using Npgsql;
using System.Data;
using Dapper;
using TheJoshProject.Api.DataAccess;

public class SqlRepository : IRepository
{
    private readonly IDbConnection _db;

    public SqlRepository(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            connectionString = configuration["TheJoshProjectDefaultConnectionString"];
        }

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new InvalidOperationException("Database connection string is not configured.");
        }

        _db = new NpgsqlConnection(connectionString);
    }

    public async Task<T?> GetDataAsync<T>(string command, object? parms = null) {
        T? result;

        result = (await _db.QueryAsync<T>(command, parms).ConfigureAwait(false)).FirstOrDefault();

        return result;
    }
    public async Task<List<T>> GetAllDataAsync<T>(string command, object? parms = null) {
        List<T> result;

        result = (await _db.QueryAsync<T>(command, parms).ConfigureAwait(false)).ToList();

        return result;
    }
    public async Task<int> EditDataAsync(string command, object parms) {
        int result;

        result = await _db.ExecuteAsync(command, parms);

        return result;
    }
    public void Dispose()
    {
        _db.Dispose();
        GC.SuppressFinalize(this);
    }
}