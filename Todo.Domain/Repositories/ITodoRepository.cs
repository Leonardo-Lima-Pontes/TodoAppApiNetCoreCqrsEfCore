using Todo.Domain.Entities;

namespace Todo.Domain.Repositories
{
    public interface ITodoRepository
    {
        void Create(TodoItem todo);
        void update(TodoItem todo);
        TodoItem GetById(Guid id, string user);
    }
}