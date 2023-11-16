namespace ZeldaGuide.Services.Location;

public class LocationService : Location.Services.Location.ILocationService
{
     private readonly Data.ApplicationDbContext? _dbContext;
    private readonly int _Location;
}

public class Services
{
    public class Location
    {
    public interface ILocationService
        {
        }
    }
}