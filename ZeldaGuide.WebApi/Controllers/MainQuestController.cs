using Microsoft.AspNetCore.Mvc;
using ZeldaGuide.Models.MainQuest;
using ZeldaGuide.Models.User;
using ZeldaGuide.Services.MainQuest;

namespace ZeldaGuide.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MainQuestController : ControllerBase
{
    private readonly IMainQuestService _mainQuestService;

    public MainQuestController(IMainQuestService mainQuestService)
    {
        _mainQuestService = mainQuestService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateMainQuest([FromBody] MainQuestCreate model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var createResult = await _mainQuestService.CreateMainQuestAsync(model);
        if (createResult)
        {
            return Ok("Main quest was created.");
        }

        return BadRequest("Main quest could not be created.");
    }

    [HttpGet("{questId:int}")]
    public async Task<IActionResult> GetById([FromRoute] int questId)
    {
        MainQuestDetail? mainQuestDetail = await _mainQuestService.GetMainQuestByIdAsync(questId);

        if (mainQuestDetail is null)
        {
            return NotFound();
        }

        return Ok(mainQuestDetail);
    }
}
