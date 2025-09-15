using CampusLearn.Domain.Common;
namespace CampusLearn.Domain.Account;
public class User : EntityBase
{
    public int UserId { get; set; }
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public string Role { get; set; } = "STUDENT";
    public void UpdateProfile(string name) => Name = name;
}