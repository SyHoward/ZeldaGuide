using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ZeldaGuide.Data;
using ZeldaGuide.Data.Entities;
using ZeldaGuide.Models.ToDo;

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

    public async Task<IEnumerable<ToDoListItem>> GetAllToDoAsync()
    {
        List<ToDoListItem> toDos = await _dbContext.ToDos
            .Where(entity => entity.OwnerId == _userId)
            .Select(entity => new ToDoListItem
            {
                Id = entity.Id,
                MainQuests = entity.MainQuests
            })
            .ToListAsync();

        return toDos;
    }
}
