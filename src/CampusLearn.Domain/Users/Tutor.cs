using CampusLearn.Domain.Common;
using CampusLearn.Domain.TopicsNS;
namespace CampusLearn.Domain.Users;
public class Tutor : User
{
    public List<string> AssignedModules { get; set; } = new();
    public List<Topic> TutorTopics { get; set; } = new();
    public List<Resource> UploadedResources { get; set; } = new();
}