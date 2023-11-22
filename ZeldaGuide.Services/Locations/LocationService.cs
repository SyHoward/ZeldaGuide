
using ZeldaGuide.Models.Locations;

namespace ZeldaGuide.Services.Locations;

public class LocationService : ILocationService
{
     private readonly Data.ApplicationDbContext? _dbContext;
    private readonly int _Location;


    public Task<bool> CreateLocationAsync(LocationCreate model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteLocationAsync(int questId)
    {
        throw new NotImplementedException();
    }

    public Task GetAllLocationAsync()
    {
        throw new NotImplementedException();
    }


    public Task<bool> UpdateLocationAsync(LocationUpdate request)
    {
        throw new NotImplementedException();
    }

    Task<LocationDetail?> GetLocationByIdAsync(int questId)
    {
        throw new NotImplementedException();
    }

    Task<LocationDetail?> ILocationService.GetLocationByIdAsync(int questId)
    {
        throw new NotImplementedException();
    }
}

