using Microsoft.AspNetCore.Mvc;
using ZeldaGuide.Data;
using ZeldaGuide.Models.User;
using ZeldaGuide.Services.Locations;
using ZeldaGuide.Services.User;
using Microsoft.EntityFrameworkCore;

namespace ZeldaGuide.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LocationsController : ControllerBase
{
    private readonly LocationService locationsService;
    public LocationController(LocationService)
    {
        _locationService = locationService;
    }
    public async Task<IActionResult> GetLocations()
    {
        List<Location> locations = await _context.Locations.ToListAsync();
        return Ok(Location);
    }
    [HttpPost]
    public async Task<IActionResult> PostLocations([FromBody] Location request)
    {
        if (ModelState.IsValid)
        {
            _context.Locations.Add(request);
            await _context.SaveChangesAsync();
            return Ok();
        }
        return BadRequest(ModelState);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult>GetLocationsById(int id)
    {
        Location? locations = await _context.Location.Findasync(id);

        if (locations is null)
        {
            return NotFound();
        }
        return Ok(location);
    }
    [HttpPost]
    [Route("{id}")]
    public async Task<IActionResult> UpdateLocations([Fromform] LocationCreate request)
    {
        var oldLocation = await _context.Location.FindAsync(id);
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
}