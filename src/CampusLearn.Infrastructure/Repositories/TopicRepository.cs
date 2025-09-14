using MongoDB.Driver;
using CampusLearn.Domain.TopicsNS;
using CampusLearn.Domain.QA;
using CampusLearn.Infrastructure.Persistence;
namespace CampusLearn.Infrastructure.Repositories;
public class TopicRepository
{
    private readonly IMongoCollection<Topic> _topics;
    public TopicRepository(MongoContext ctx){ _topics = ctx.GetCollection<Topic>("topics"); }
    public async Task<Topic> InsertAsync(Topic t){ await _topics.InsertOneAsync(t); return t; }
    public async Task<List<Topic>> LatestAsync(int take) => await _topics.Find(_ => true).SortByDescending(t => t.CreatedAt).Limit(take).ToListAsync();
    public async Task<Topic?> GetAsync(string id) => await _topics.Find(t => t.Id == id).FirstOrDefaultAsync();
    public async Task UpdateAsync(Topic t) => await _topics.ReplaceOneAsync(x => x.Id == t.Id, t);
}