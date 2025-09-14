using Microsoft.AspNetCore.Mvc;
using CampusLearn.Application.Abstractions;

namespace CampusLearn.Api.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly IUserService _users;
    public UsersController(IUserService users){ _users = users; }

    public record RegisterReq(string Name, string Email, string Password, string Role);

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterReq req)
    {
        var u = await _users.RegisterAsync(req.Name, req.Email, req.Password, req.Role);
        return Ok(new { u.Id, u.Name, u.Email, u.Role });
    }
}