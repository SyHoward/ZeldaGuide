using Microsoft.AspNetCore.Mvc;
using ZeldaGuide.Services.Location;
using ZeldaGuide.Models.Location;
using static ZeldaGuide.Services.Location.Services.Location;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Location.Services.Location;

namespace ZeldaGuide.WebApi.Controllers;
    
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
{
    private readonly LocationService _locationService;

    public LocationController(ILocationService locationService)
    {
        _locationService = locationService;
    }

    [HttpPost]
    public Task<IActionResult> CreateLocation([FromBody] LocationCreate model);
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return BadRequest("Location could not be created.");
        }



    
    [HttpGet]
    public async Task<IActionResult> GetAllLocations()
    {
        var quests = await ILocationService.GetLocationAsync();
        return Ok(Location);
    }

IActionResult Ok(object location)
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

