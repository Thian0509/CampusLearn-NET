using CampusLearn.Domain.QA;
namespace CampusLearn.Domain.Comms;
public class Forum
{
    public List<Question> Posts { get; set; } = new();
    public List<string> Faqs { get; set; } = new();
    public List<string> TrendingTopics { get; set; } = new();
}