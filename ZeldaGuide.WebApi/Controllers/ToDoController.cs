using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using ZeldaGuide.Services.ToDo;

namespace ZeldaGuide.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ToDoController : ControllerBase
{
    private readonly IToDoService _toDoService;

    public ToDoController(IToDoService toDoService)
    {
        _toDoService = toDoService;
    }

    //GET  api/ToDo
    [HttpGet]
    public async Task<IActionResult> GetAllToDos()
    {
        var toDos = await _toDoService.GetAllToDoAsync();
        return Ok(toDos);
    }
}

