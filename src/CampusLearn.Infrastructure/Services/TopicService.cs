using CampusLearn.Application.Abstractions;
using CampusLearn.Domain.QA;
using CampusLearn.Domain.TopicsNS;
using CampusLearn.Infrastructure.Repositories;
namespace CampusLearn.Infrastructure.Services;
public class TopicService : ITopicService
{
    private readonly TopicRepository _repo;
    public TopicService(TopicRepository repo){ _repo = repo; }
    public async Task<Topic> CreateTopicAsync(string creatorUserId, string title, string description, string moduleCode)
    {
        var t = new Topic{ Id = Guid.NewGuid().ToString(), CreatedByUserId = creatorUserId, Title = title, Description = description, ModuleCode = moduleCode, CreatedAt = DateTime.UtcNow };
        return await _repo.InsertAsync(t);
    }
    public async Task<Question> PostQuestionAsync(string topicId, string studentId, string content, bool anonymous)
    {
        var t = await _repo.GetAsync(topicId) ?? throw new InvalidOperationException("Topic not found");
        var q = new Question{ Id = Guid.NewGuid().ToString(), QuestionId = Random.Shared.Next(1000,9999), PostedByStudentId = studentId, Content = content, IsAnonymous = anonymous, CreatedAt = DateTime.UtcNow };
        t.Questions.Add(q);
        await _repo.UpdateAsync(t);
        return q;
    }
    public async Task<Response> RespondAsync(string topicId, string questionId, string userId, string content)
    {
        var t = await _repo.GetAsync(topicId) ?? throw new InvalidOperationException("Topic not found");
        var q = t.Questions.FirstOrDefault(x => x.Id == questionId) ?? throw new InvalidOperationException("Question not found");
        var r = new Response{ Id = Guid.NewGuid().ToString(), ResponseId = Random.Shared.Next(1000,9999), PostedByUserId = userId, Content = content, CreatedAt = DateTime.UtcNow };
        q.Responses.Add(r);
        await _repo.UpdateAsync(t);
        return r;
    }
    public Task<List<Topic>> GetLatestAsync(int take = 10) => _repo.LatestAsync(take);
}