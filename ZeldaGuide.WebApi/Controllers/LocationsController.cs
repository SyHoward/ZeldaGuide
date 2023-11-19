using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using ZeldaGuide.Services.Location;
using Microsoft.EntityFrameworkCore;
using Location.Services.Location;


namespace ZeldaGuide.WebApi.Controllers;
    
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
{
    private readonly LocationService _locationService;

    public object context { get; private set; }

    public LocationController(LocationService LocationService)
    {
        _locationService = LocationService;
    }

    [HttpPost]
    public Task<IActionResult> PostLocation([FromBody] LocationDetail request, object ModelState, object GetLocationById)
    {
        if (ModelState.IsValid)
        {
            return Task.FromResult<IActionResult>(BadRequestResult(ModelState));
        }
            Context.Location.Addnew Location;
            Location = model.Location;
            GetLocationById = model.LocationId;
        }

IActionResult BadRequestResult(object modelState)
{
    throw new NotImplementedException();
}



    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetAllLocation()
    {
        var location = await _locationService
        GetAllLocationAsync();
        return Ok(location);
    }

    private void GetAllLocationAsync()
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateLocation([FromForm] LocationCreate request)
    {
        var oldLocation = await context.Location.FindAsync(id);
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
        var location = await context.Location.FindAsync(id);
        if (location is null)
        {
            return NotFound();
        }

        context.Location.Remove(location);
        await context.SaveChangesAsync();
        return Ok();
    }
}

internal class model
{
}