using Todo.Models;

namespace Todo.Services;

public class TodosService : ITodosService
{
    public Task<IEnumerable<TodoItem>> GetTodosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TodoItem> GetTodoByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddTodoAsync(TodoItem todo)
    {
        throw new NotImplementedException();
    }

    public Task ToggleCompleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTodoAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCompletedTodosAsync()
    {
        throw new NotImplementedException();
    }
}