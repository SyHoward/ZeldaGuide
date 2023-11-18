using ZeldaGuide.Models.SideAdventure;

public interface ISideAdventureService
{
    Task<bool> CreateSideAdventureAsync(SideAdventureCreate model);
    Task<SideAdventureDetail?> GetSideAdventureByIdAsync(int sideAdventureId);
}