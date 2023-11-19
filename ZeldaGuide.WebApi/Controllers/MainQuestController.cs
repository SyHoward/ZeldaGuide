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

    //* GET api/MainQuest
    [HttpGet]
    public async Task<IActionResult> GetAllMainQuests()
    {
        var quests = await _mainQuestService.GetAllMainQuestsAsync();
        return Ok(quests);
    }

    //* PUT api/MainQuest
    [HttpPut]
    public async Task<IActionResult> UpdateMainQuestById([FromBody] MainQuestUpdate request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return await _mainQuestService.UpdateMainQuestAsync(request)
            ? Ok("Main quest updated successfully.")
            : BadRequest("Main quest could not be updated.");
    }

    //* DELETE api/MainQuest/5
    [HttpDelete("{questId:int}")]
    public async Task<IActionResult> DeleteMainQuest([FromRoute] int questId)
    {
        return await _mainQuestService.DeleteMainQuestAsync(questId)
            ? Ok($"Main quest {questId} was deleted successfully.")
            : BadRequest($"Main quest {questId} could not be deleted.");
    }
}
