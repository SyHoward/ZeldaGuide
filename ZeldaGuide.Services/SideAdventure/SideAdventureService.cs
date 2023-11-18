using Microsoft.EntityFrameworkCore;
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

    public async Task<IEnumerable<SideAdventureListItem>> GetAllSideAdventuresAsync()
    {
        List<SideAdventureListItem> sideAdventures = await _dbContext.SideAdventures
            .Select(entity => new SideAdventureListItem
            {
                Id = entity.Id,
                Name = entity.Name
            })
            .ToListAsync();

        return sideAdventures;
    }

    public async Task<bool> UpdateSideAdventureAsync(SideAdventureUpdate request)
    {
        //* Find the side adventure and validate that it exists
        SideAdventureEntity? entity = await _dbContext.SideAdventures.FindAsync(request.Id);

        //* It checks if the entity under the given Id exists
        if (entity is null)
            return false;
        
        //* Now we update the entity's properties
        entity.Name = request.Name;
        entity.Description = request.Description;

        //* Save the changes to the database and capture how many rows were updated
        int numberOfChanges = await _dbContext.SaveChangesAsync();

        //* numberOfChanges is stated to be equal to 1 because only one row is updated
        return numberOfChanges == 1;
    }
}