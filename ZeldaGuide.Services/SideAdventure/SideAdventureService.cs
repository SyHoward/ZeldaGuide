using ZeldaGuide.Data;
using ZeldaGuide.Data.Entities;
using ZeldaGuide.Models.SideAdventure;

namespace ZeldaGuide.Services.SideAdventure;
public class SideAdventureService : ISideAdventureService
{
    private readonly ApplicationDbContext _dbContext;

    public SideAdventureService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CreateSideAdventureAsync(SideAdventureCreate model)
    {
        SideAdventureEntity entity = new()
        {
            Name = model.Name,
            Description = model.Description
        };

        _dbContext.SideAdventures.Add(entity);
        int numberOfChanges = await _dbContext.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<SideAdventureDetail?> GetSideAdventureByIdAsync(int sideAdventureId)
    {
        SideAdventureEntity? entity = await _dbContext.SideAdventures.FindAsync(sideAdventureId);
        if (entity is null)
            return null;
        SideAdventureDetail detail = new()
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description
        };

        return detail;
    }
}