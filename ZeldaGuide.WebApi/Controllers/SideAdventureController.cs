using Microsoft.AspNetCore.Mvc;
using ZeldaGuide.Models.SideAdventure;

namespace ZeldaGuide.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SideAdventureController : ControllerBase
{
    private readonly ISideAdventureService _sideAdventureService;

    public SideAdventureController(ISideAdventureService sideAdventureService)
    {
        _sideAdventureService = sideAdventureService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateSideAdventure([FromBody] SideAdventureCreate model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var createResult = await _sideAdventureService.CreateSideAdventureAsync(model);
        if (createResult)
        {
            return Ok("Side adventure was created.");
        }

        return BadRequest("Side adventure could not be created.");
    }

    [HttpGet("{sideAdventureId:int}")]
    public async Task<IActionResult> GetById([FromRoute] int sideAdventureId)
    {
        SideAdventureDetail? sideAdventureDetail = await _sideAdventureService.GetSideAdventureByIdAsync(sideAdventureId);

        if (sideAdventureDetail is null)
        {
            return NotFound();
        }

        return Ok(sideAdventureDetail);
    }

    //* GET api/SideAdventure
    [HttpGet]
    public async Task<IActionResult> GetAllSideAdventures()
    {
        var sideAdventures = await _sideAdventureService.GetAllSideAdventuresAsync();
        return Ok(sideAdventures);
    }
}
