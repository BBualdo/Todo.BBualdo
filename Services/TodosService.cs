namespace Todo.Services;

public class TodosService(ITodosRepository repository) : ITodosService
{
    private readonly ITodosRepository _repository = repository;
    public Task<IResult> GetTodos()
    {
        throw new NotImplementedException();
    }

    public Task<IResult> ToggleTodoCompleted(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IResult> DeleteTodo(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IResult> DeleteCompletedTodos()
    {
        throw new NotImplementedException();
    }
}