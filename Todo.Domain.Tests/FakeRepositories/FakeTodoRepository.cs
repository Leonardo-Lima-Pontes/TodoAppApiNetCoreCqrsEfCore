using System;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.FaceRepositories;

public class FakeTodoRepository : ITodoRepository
{
    public void Create(TodoItem todo) { }

    public TodoItem GetById(Guid id, string user) { return new TodoItem("", DateTime.Now, ""); }

    public void update(TodoItem todo) { }
}