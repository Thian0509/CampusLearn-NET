namespace CampusLearn.Domain.AI;
public interface IAIChatbot
{
    Task<string> AnswerQuestionAsync(string question);
    Task<string> RecommendResourceAsync(string topic);
    Task<bool> EscalateToTutorAsync(string topicId, string studentId);
}