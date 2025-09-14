using CampusLearn.Domain.TopicsNS;
using CampusLearn.Domain.QA;
namespace CampusLearn.Application.Abstractions;
public interface ITopicService
{
    Task<Topic> CreateTopicAsync(string creatorUserId, string title, string description, string moduleCode);
    Task<Question> PostQuestionAsync(string topicId, string studentId, string content, bool anonymous);
    Task<Response> RespondAsync(string topicId, string questionId, string userId, string content);
    Task<List<Topic>> GetLatestAsync(int take = 10);
}