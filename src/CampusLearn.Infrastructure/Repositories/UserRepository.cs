using MongoDB.Driver;
using CampusLearn.Domain.Account;
using CampusLearn.Infrastructure.Persistence;
namespace CampusLearn.Infrastructure.Repositories;
public class UserRepository
{
    private readonly IMongoCollection<User> _col;
    public UserRepository(MongoContext ctx) { _col = ctx.GetCollection<User>("users"); }
    public async Task<User> InsertAsync(User u){ await _col.InsertOneAsync(u); return u; }
    public Task<User?> GetByEmailAsync(string email) => _col.Find(x => x.Email == email).FirstOrDefaultAsync();
}