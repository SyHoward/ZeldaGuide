using ZeldaGuide.Models.MainQuest;

namespace ZeldaGuide.Services.MainQuest;
public interface IMainQuestService
{
    Task<bool> CreateMainQuestAsync(MainQuestCreate model);
}