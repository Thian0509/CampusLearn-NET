using CampusLearn.Domain.Common;
namespace CampusLearn.Domain.Users;
public class Admin : User
{
    public List<string> ModerationLog { get; set; } = new();
}