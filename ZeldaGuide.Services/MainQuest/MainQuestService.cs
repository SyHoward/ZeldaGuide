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

    public async Task<MainQuestDetail?> GetMainQuestByIdAsync(int questId)
    {
        MainQuestEntity? entity = await _context.MainQuests.FindAsync(questId);
        if (entity is null)
            return null;
        MainQuestDetail detail = new()
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description
        };

        return detail;
    }

    public async Task<bool> UpdateMainQuestAsync(MainQuestUpdate request)
    {
        //* Find the main quest and validate that it exists
        MainQuestEntity? entity = await _context.MainQuests.FindAsync(request.Id);

        //* It checks if the entity under the given Id exists
        if (entity is null)
            return false;
        
        //* Now we update the entity's properties
        entity.Name = request.Name;
        entity.Description = request.Description;

        //* Save the changes to the database and capture how many rows were updated
        int numberOfChanges = await _context.SaveChangesAsync();

        //* numberOfChanges is stated to be equal to 1 because only one row is updated
        return numberOfChanges == 1;
    }
}