using Microsoft.AspNetCore.Identity;
using ZeldaGuide.Data;
using ZeldaGuide.Data.Entities;

namespace ZeldaGuide.Services.ToDo;

public class ToDoService : IToDoService
{
    private readonly ApplicationDbContext _dbContext;
    private readonly int _userId;
    
    public ToDoService(UserManager<UserEntity> userManager,
                        SignInManager<UserEntity>signInManager,
                        ApplicationDbContext dbContext)
    
    {
        var currentUser = signInManager.Context.User;
        var userIdClaim = userManager.GetUserId(currentUser);
        var hasValidId = int.TryParse(userIdClaim, out _userId);

        if (hasValidId == false)
        _dbContext = dbContext;
    }
}
