using Microsoft.EntityFrameworkCore;
using Todo.Data;
using Todo.Repositories;
using Todo.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TodoDbContext>(opt => opt.UseInMemoryDatabase("Todos"));
builder.Services.AddScoped<ITodosRepository, TodosRepository>();
builder.Services.AddScoped<ITodosService, TodosService>();

var app = builder.Build();

var todoItems = app.MapGroup("todos");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseDefaultFiles();

app.Run();