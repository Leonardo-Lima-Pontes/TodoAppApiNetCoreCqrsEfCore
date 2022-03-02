using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.FaceRepositories;

public class FakeTodoRepository : ITodoRepository
{
    public void Create(TodoItem todo) { }
    public void update(TodoItem todo) { }
}