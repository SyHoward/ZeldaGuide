using ZeldaGuide.Models.ToDo;

namespace ZeldaGuide.Services.ToDo;

public interface IToDoService
{
    Task<ToDoListItem?> CreateToDoAsync(ToDoCreate request);
    Task<IEnumerable<ToDoListItem>> GetAllToDoAsync();
    Task<ToDoDetail?> GetToDoByIdAsync(int noteId);
    Task<bool> UpdateToDoAsync(ToDoUpdate request);
}