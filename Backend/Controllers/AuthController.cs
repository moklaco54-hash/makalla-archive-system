using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login(LoginRequest req)
    {
        if (
            (req.Username == "faiz" && req.Password == "123456") ||
            (req.Username == "manager" && req.Password == "123456") ||
            (req.Username == "amal" && req.Password == "123456")
        )
        {
            return Ok(new { success = true, role = req.Username });
        }

        return Unauthorized();
    }
}

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
