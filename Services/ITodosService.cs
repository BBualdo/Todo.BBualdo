using Todo.Models;

namespace Todo.Services;

public interface ITodosService
{
    Task<IEnumerable<TodoItem>> GetTodosAsync();
    Task<TodoItem> GetTodoByIdAsync(int id);
    Task AddTodoAsync(TodoItem todo);
    Task ToggleCompleteAsync(int id);
    Task DeleteTodoAsync(int id);
    Task DeleteCompletedTodosAsync();
}