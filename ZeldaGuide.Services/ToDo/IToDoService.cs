using ZeldaGuide.Models.ToDo;

namespace ZeldaGuide.Services.ToDo;

public interface IToDoService
{
    Task<IEnumerable<ToDoListItem>> GetAllToDoAsync();
}