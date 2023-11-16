using Location.Services.Location;
using Microsoft.AspNetCore.Mvc;
using ZeldaGuide.Services.Location;

namespace ZeldaGuide.WebApi.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class LocationsController : ControllerBase
    
    private readonly LocationService locationService;
    private readonly object id;
    private readonly ILocationService locationService;
    private object _context;

    public LocationController (LocationService, ILocationService? ILocationService)
    {
        ILocationService = LocationService;
    }
    public async Task<IActionResult> GetLocations()
    {
        List<Location> locations = await _context.Location.ToListAsync();
        return Ok(Location);
    }

    private IActionResult Ok(object location)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public Task<IActionResult> PostLocations([FromBody] LocationDetail request, object ModelState)
    {
        if (ModelState.IsValid)
        {
            return Task.FromResult<IActionResult>(BadRequestResult(ModelState));
        }
            _context.Location.Addnew Location
            Location = model.Location,
            GetLocationsById = model.LocationId,
        } 
        public class LocationCreate
        {
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

