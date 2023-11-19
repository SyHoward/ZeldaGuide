using Microsoft.AspNetCore.Mvc;
using ZeldaGuide.Models.Responses;
using ZeldaGuide.Models.User;
using ZeldaGuide.Services.User;

namespace ZeldaGuide.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateLocations([FromBody] UserRegister request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
            
        var response = await _UserService.CreateUser;
        {
            TextResponse response = new("User was registered.");
            return Ok(response);
        }

        return BadRequest(new TextResponse("User could not be registered."));
    }

    [HttpGet("{userId:int}")]
    public async Task<IActionResult> GetById([FromRoute] int userId)
    {
        UserDetail? detail = await _userService.GetUserByIdAsync(userId);

        if (detail is null)
        {
            return NotFound();
        }

        return Ok(detail);
    }
}
