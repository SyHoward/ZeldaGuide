using Microsoft.AspNetCore.Http;
using ZeldaGuide.Data;
using ZeldaGuide.Data.Entities;
using ZeldaGuide.Models.MainQuest;

namespace ZeldaGuide.Services.MainQuest;
public class MainQuestService : IMainQuestService
{
    private readonly ApplicationDbContext _context;
    public MainQuestService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<bool> CreateMainQuestAsync(MainQuestCreate model)
    {
        MainQuestEntity entity = new()
        {
            Name = model.Name,
            Description = model.Description
        };

        _context.MainQuests.Add(entity);
        int numberOfChanges = await _context.SaveChangesAsync();

        return numberOfChanges == 1;
    }
}