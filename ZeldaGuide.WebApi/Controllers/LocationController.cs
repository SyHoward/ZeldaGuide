using Location.Services.Location;
using Microsoft.AspNetCore.Mvc;
using ZeldaGuide.Services.Location;

namespace ZeldaGuide.WebApi.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class LocationsController : ControllerBase
    {
    private readonly LocationService locationsService;
    private readonly object id;
    private object _context;

    public LocationController(LocationService)
    {
        ILocationService = locationService;
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
        Location? location = await _context.Location.Findasync(id);

        if (location is null)
        {
            return NotFound();
        }
        return Ok(location);
    }

    private IActionResult Ok(Location? location)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateLocation([FromForm] LocationCreate request)
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
    [HttpDelete]
    [Route("{id}")]

    public async Task<IActionResult> DeleteLocation([FromRoute] int id)
    {
        var location = await _context.Location.FindAsync(id);
        if (location is null)
        {
            return NotFound();
        }

        _context.Location.Remove(location);
        await _context.SaveChangesAsync();
        return Ok();
    }
}