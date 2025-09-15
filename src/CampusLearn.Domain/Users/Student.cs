using CampusLearn.Domain.TopicsNS;
using CampusLearn.Domain.QA;
namespace CampusLearn.Domain.Users;
public class Student : User
{
    public string AcademicBackground { get; set; } = "";
    public List<Topic> SubscribedTopics { get; set; } = new();
    public List<Question> InteractionHistory { get; set; } = new();
    public Topic CreateHelpTopic(string title, string description, string moduleCode) =>
        new Topic { Title = title, Description = description, ModuleCode = moduleCode, CreatedByUserId = this.Id };
}