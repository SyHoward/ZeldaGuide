namespace Locations.Services.Locations;

public interface ILocationsService
{
    Task<bool> RegisterLocationsAsync(LocationsRegister model);
    Task<LocationsDetail?> GetLocationsByIdAsync(int Locations);
}