namespace Location.Services.Location;

public interface ILocationService
{
    Task<bool> RegisterLocationsAsync(LocationRegister model);
    Task<LocationDetail?> GetLocationsByIdAsync(int Locations);
}

public class LocationDetail
{
}

public class LocationRegister
{
}