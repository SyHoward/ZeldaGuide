using ZeldaGuide.Models.MainQuest;

namespace ZeldaGuide.Services.MainQuest;
public interface IMainQuestService
{
    Task<bool> CreateMainQuestAsync(MainQuestCreate model);
    Task<MainQuestDetail?> GetMainQuestByIdAsync(int questId);
    Task<IEnumerable<MainQuestListItem>> GetAllMainQuestsAsync();
    Task<bool> UpdateMainQuestAsync(MainQuestUpdate request);
    Task<bool> DeleteMainQuestAsync(int questId);
}