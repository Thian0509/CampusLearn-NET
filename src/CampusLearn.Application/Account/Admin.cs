using CampusLearn.Domain.Account;

namespace CampusLearn.Application.Account;

public class Admin : User, IAccount
{
    public List<string> ModerationLog { get; set; } = new();

    public Admin(string name)
    {
        Name = name;
    }

    public string GetDetails()
    {
        return $"Admin: {Name}";
    }
    public void Register()
    {
        Console.WriteLine($"Admin {Name} has registered.");
    }

    public void LogIn()
    {
        Console.WriteLine($"Admin {Name} has logged in.");
    }

    public void LogOut()
    {
        Console.WriteLine($"Admin {Name} has logged out.");
    }

    public void UpdateProfile(string name)
    {
        Name = name;
    }
}
