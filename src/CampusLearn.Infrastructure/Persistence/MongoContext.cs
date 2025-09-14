using Microsoft.Extensions.Options;
using MongoDB.Driver;
using CampusLearn.Infrastructure.Config;
namespace CampusLearn.Infrastructure.Persistence;
public class MongoContext
{
    public IMongoDatabase Database { get; }
    public MongoContext(IOptions<MongoSettings> settings)
    {
        var client = new MongoClient(settings.Value.ConnectionString);
        Database = client.GetDatabase(settings.Value.Database);
    }
    public IMongoCollection<T> GetCollection<T>(string name) => Database.GetCollection<T>(name);
}