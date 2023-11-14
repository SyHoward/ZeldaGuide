using Microsoft.AspNetCore.Mvc;
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
}
