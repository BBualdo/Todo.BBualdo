﻿using Todo.Models;

namespace Todo.Services;

public interface ITodosService
{
    Task<IResult> GetTodos();
    Task<IResult> ToggleTodoCompleted(int id);
    Task<IResult> DeleteTodo(int id);
    Task<IResult> DeleteCompletedTodos();
}