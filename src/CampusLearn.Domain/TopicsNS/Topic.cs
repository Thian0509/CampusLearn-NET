using CampusLearn.Domain.Common;
using CampusLearn.Domain.QA;
namespace CampusLearn.Domain.TopicsNS;
public class Topic : EntityBase
{
    public int TopicId { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string ModuleCode { get; set; } = "";
    public string CreatedByUserId { get; set; } = "";
    public List<string> SubscriberStudentIds { get; set; } = new();
    public List<Resource> Resources { get; set; } = new();
    public List<Question> Questions { get; set; } = new();
}