namespace ZeldaGuide.Services.Location;

public class LocationService : ILocationService
{
     private readonly ApplicationDbContext _dbContext;
    private readonly int _Location;
    
    public LocationService(UserManager<UserEntity> userManager,
                         dbContext)
    private readonly ApplicationDbContext _dbContext;
    private readonly int _userId;
    
    public LocationService(UserManager<UserEntity> userManager,
                        SignInManager<UserEntity>signInManager,
                        ApplicationDbContext dbContext)
    
    {
        var currentUser = signInManager.Context.User;
        var userIdClaim = userManager.GetUserId(currentUser);
        var hasValidId = int.TryParse(userIdClaim, out _userId);

        if (hasValidId == false)
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<ToDoListItem>> GetAllToDoAsync();
}    