using System.Security.Cryptography;
using System.Text;
using CampusLearn.Domain.Users;
using CampusLearn.Application.Abstractions;
using CampusLearn.Infrastructure.Repositories;
namespace CampusLearn.Infrastructure.Services;
public class UserService : IUserService
{
    private readonly UserRepository _repo;
    public UserService(UserRepository repo){ _repo = repo; }
    public async Task<User> RegisterAsync(string name, string email, string password, string role)
    {
        var hash = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(password)));
        var user = new User{ Id = Guid.NewGuid().ToString(), Name = name, Email = email, PasswordHash = hash, Role = role };
        return await _repo.InsertAsync(user);
    }
    public Task<User?> GetByEmailAsync(string email) => _repo.GetByEmailAsync(email);
}