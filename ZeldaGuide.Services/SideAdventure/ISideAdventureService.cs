using ZeldaGuide.Models.SideAdventure;

public interface ISideAdventureService
{
    Task<bool> CreateSideAdventureAsync(SideAdventureCreate model);
    Task<SideAdventureDetail?> GetSideAdventureByIdAsync(int sideAdventureId);
    Task<IEnumerable<SideAdventureListItem>> GetAllSideAdventuresAsync();
    Task<bool> UpdateSideAdventureAsync(SideAdventureUpdate request);
    Task<bool> DeleteSideAdventureAsync(int sideAdventureId);
}