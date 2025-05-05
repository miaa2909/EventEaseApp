using Microsoft.AspNetCore.Mvc;
using EventEaseApp.Shared.Models;

namespace EventEaseApp.Shared.Models
{
[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    [HttpPost]
    public IActionResult RegisterUser([FromBody] User user)
    {
        return Ok($"User {user.Username} registered successfully!");
    }
}

}