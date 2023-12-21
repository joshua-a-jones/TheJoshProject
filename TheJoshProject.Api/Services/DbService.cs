using Npgsql;
using System.Data;
using Dapper;

namespace TheJoshProject.Api.Services;

public class DbService : IDbService {

    private readonly IDbConnection _db;

    public DbService(IConfiguration configuration)
    {
        var connectionString = Environment.GetEnvironmentVariable("TheJoshProjectDefaultConnectionString");
        _db = new NpgsqlConnection(connectionString);
    }

    public async Task<T?> GetAsync<T>(string command, object? parms = null) {
        T? result;

        result = (await _db.QueryAsync<T>(command, parms).ConfigureAwait(false)).FirstOrDefault();

        return result;
    }
    public async Task<List<T>> GetAll<T>(string command, object? parms = null) {
        List<T> result;

        result = (await _db.QueryAsync<T>(command, parms).ConfigureAwait(false)).ToList();

        return result;
    }
    public async Task<int> EditData(string command, object parms) {
        int result;

        result = await _db.ExecuteAsync(command, parms);

        return result;
    }

    public async Task<bool> Exists(string command, object parms) {
        bool result;

        result = (await _db.QueryAsync(command, parms).ConfigureAwait(false)).Any();

        return result;
    }
}