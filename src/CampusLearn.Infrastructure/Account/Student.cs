using CampusLearn.Domain.Account;
using CampusLearn.Domain.QA;
using CampusLearn.Domain.TopicsNS;
namespace CampusLearn.Infrastructure.Account;

public class Student : User, IAccount
{

    public string AcademicBackground { get; set; } = "";
    public List<Topic> SubscribedTopics { get; set; } = new();
    public List<Question> InteractionHistory { get; set; } = new();
    public Topic CreateHelpTopic(string title, string description, string moduleCode) =>
        new Topic { Title = title, Description = description, ModuleCode = moduleCode, CreatedByUserId = this.Id };

    public Student(string name, int studentId)
    {
        Name = name;
        UserId = studentId;
    }

    public string GetDetails()
    {
        return $"Student: {Name}, ID: {UserId}";
    }

    public void Register()
    {
        Console.WriteLine($"User {Name} has registered.");
    }

    public void LogIn()
    {
        Console.WriteLine($"User {Name} has logged in.");
    }

    public void LogOut()
    {
        Console.WriteLine($"User {Name} has logged out.");
    }

    public void UpdateProfile(string name)
    {
        Name = name;
    }
}
