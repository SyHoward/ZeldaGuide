using ZeldaGuide.Models.Locations;

namespace ZeldaGuide.Services.Locations;

public interface ILocationService
{
    Task<bool> CreateLocationAsync(LocationCreate model);
    Task<LocationDetail?> GetLocationByIdAsync(int questId);
//    Task<IEnumerable<LocationListItem> GetLocationByAsync();
    Task<bool> UpdateLocationAsync(LocationUpdate request);
    Task<bool> DeleteLocationAsync(int questId);
}

