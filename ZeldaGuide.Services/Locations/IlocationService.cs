namespace Location.Services.Location;

public interface ILocationService
{
    Task<bool> CreateMainQuestAsync(LocationCreate model);
    Task<LocationDetail?> GetMainQuestByIdAsync(int questId);
    Task<IEnumerable<LocationListItem>> GetAllMainQuestsAsync();
    Task<bool> UpdateMainQuestAsync(LocationUpdate request);
    Task<bool> DeleteMainQuestAsync(int questId);
}

public class LocationCreate
{
}

public class LocationUpdate
{
}

public class LocationListItem
{
}

public class LocationDetail
{
}

public class LocationRegister
{
}