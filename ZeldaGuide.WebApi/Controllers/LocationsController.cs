using Location.Services.Location;
using Microsoft.AspNetCore.Mvc;
using ZeldaGuide.Services.Location;

namespace ZeldaGuide.WebApi.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    
    private readonly LocationService 
    private object _context;

    public LocationController (LocationService ILocationService )
    {
        ILocationService = LocationService;
    }
    public async Task<IActionResult> GetLocation()
    {
        List<Location> locations = await Context.Location.ToListAsync();
        return Ok(locations);
    }



ActionResult Ok(List<Location> locations)
    {
    throw new NotImplementedException();
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
            Context.Location.Addnew Location
            Location = model.Location,
            GetLocationsById = model.LocationId,
        } 
        public class LocationCreate
        {
        }
    

    [HttpGet("{id:int}")]
    public async Task<IActionResult>GetLocationsById(int id)
    {
        Location? location = await Context.Location.Findasync(id);

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

