using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using ZeldaGuide.Services.Location;
using Microsoft.EntityFrameworkCore;

namespace ZeldaGuide.WebApi.Controllers;
    
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
{
    private readonly LocationService _locationService;

    public LocationController(LocationService toDoService)
    {
        _locationService = toDoService;
    }

    [HttpPost]
    public Task<IActionResult> PostLocation([FromBody] LocationDetail request, object ModelState)
    {
        if (ModelState.IsValid)
        {
            return Task.FromResult<IActionResult>(BadRequestResult(ModelState));
        }
            Context.Location.Addnew Location
            Location = model.Location,
            GetLocationById = model.LocationId,
        }

IActionResult BadRequestResult(object modelState)
{
    throw new NotImplementedException();
}

public class LocationCreate
        {
        }
    

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetAllLocation()
    {
        var toDos = await _locationService.GetAllLocationAsync()
        return Ok(location);
    }
    

    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateLocation([FromForm] LocationCreate request)
    {
        var oldLocation = await Context.Location.FindAsync(id);
        if (oldLocation == null)
        {
            return NotFound();
        }
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (!string.IsNullOrEmpty(model.Name))
        {
            oldLocation.Name = model.Name;
        }
        
    }
    [HttpDelete]
    [Route("{id}")]

    public async Task<IActionResult> DeleteLocation([FromRoute] int id)
    {
        var location = await Context.Location.FindAsync(id);
        if (location is null)
        {
            return NotFound();
        }

        Context.Location.Remove(location);
        await Context.SaveChangesAsync();
        return Ok();
    }
}
