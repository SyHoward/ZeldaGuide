using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using ZeldaGuide.Models.Responses;
using ZeldaGuide.Models.ToDo;
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

    //POST api/ToDo
    [HttpPost]

    public async Task<IActionResult> CreateToDo([FromBody] ToDoCreate request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var response = await _toDoService.CreateToDoAsync(request);
        if (response is not null)
            return Ok(response);

        return BadRequest(new TextResponse("Could not create ToDo."));
    }

    //GET  api/ToDo
    [HttpGet]
    public async Task<IActionResult> GetAllToDos()
    {
        var toDos = await _toDoService.GetAllToDoAsync();
        return Ok(toDos);
    }

    //GET api/ToDo/{id}
    [HttpGet("{toDoId:int}")]
    public async Task<IActionResult> GetToDoById([FromRoute] int toDoId)
    {
        ToDoDetail? detail = await _toDoService.GetToDoByIdAsync(toDoId);

        return detail is not null
            ? Ok(detail)
            : NotFound();
    }

}

