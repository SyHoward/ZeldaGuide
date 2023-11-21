using Microsoft.AspNetCore.Http;
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
            throw new Exception("Attempted to build ToDoService without Id claim.");

        _dbContext = dbContext;
    }

    public async Task<ToDoListItem?> CreateToDoAsync(ToDoCreate request)
    {
        ToDoEntity entity = new()
        {
            Owner = _userId,
            QuestId = request.NewQuestId
        };

        _dbContext.ToDos.Add(entity);
        
        var numberOfChanges = await _dbContext.SaveChangesAsync();

        if (numberOfChanges != 1)
            return null;

        ToDoListItem response = new()
        {
            ToDoId = entity.ToDoId,
            QuestId = entity.QuestId
        };
        return response;
    }

    public async Task<IEnumerable<ToDoListItem>> GetAllToDoAsync()
    {
        List<ToDoListItem> toDos = await _dbContext.ToDos
            .Where(entity => entity.Owner == _userId)
            .Select(entity => new ToDoListItem
            {
                ToDoId = entity.ToDoId,
                QuestId = entity.QuestId
            })
            .ToListAsync();

        return toDos;
    }

    public async Task<ToDoDetail?> GetToDoByIdAsync(int toDoId)
    {
        ToDoEntity? entity = await _dbContext.ToDos
            .FirstOrDefaultAsync(e =>
                e.ToDoId == toDoId && e.Owner == _userId
            );

        return entity is null ? null : new ToDoDetail
        {
            ToDoId = entity.ToDoId,
            QuestId = entity.QuestId
        };
    }

    public async Task<bool> UpdateToDoAsync(ToDoUpdate request)
    {
        ToDoEntity? entity = await _dbContext.ToDos.FindAsync(request.ToDoId);

        if (entity?.Owner != _userId)
            return false;

        entity.ToDoId = request.ToDoId;
        entity.QuestId = request.NewQuestId;

        int numberOfChanges = await _dbContext.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<bool> DeleteToDoAsync(int toDoId)
    {
        var toDoEntity = await _dbContext.ToDos.FindAsync(toDoId);

        if (toDoEntity?.Owner != _userId)
            return false;

        _dbContext.ToDos.Remove(toDoEntity);
        return await _dbContext.SaveChangesAsync() == 1;
    }

}
