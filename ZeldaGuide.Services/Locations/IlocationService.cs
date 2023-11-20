namespace Location.Services.Location;

public interface ILocationService
{
    Task<bool> CreateLocationAsync(ZeldaGuide.Models.Location.LocationCreate model);
    Task<LocationDetail?> GetLocationByIdAsync(int questId);
    Task<IEnumerable<LocationListItem> GetLocationByAsync();
    Task<bool> UpdateLocationAsync(LocationUpdate request);
    Task<bool> DeleteLocationAsync(int questId);
}

internal class LocationListItem
{
}

public class LocationUpdate
{
}

internal class Task<T1, T2>
{
}