namespace CampusLearn.Domain.Account;
public interface IUserService
{
    Task<User> RegisterAsync(string name, string email, string password, string role);
    Task<User?> GetByEmailAsync(string email);
}