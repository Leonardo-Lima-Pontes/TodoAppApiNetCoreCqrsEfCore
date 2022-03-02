using Flunt.Notifications;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Entities;
using Todo.Domain.Handlers.Contracts;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers;

public class TodoHandler : Notifiable, IHandler<CreateTodoCommand>
{
    private readonly ITodoRepository _todoRepository;

    public TodoHandler(ITodoRepository todoRepository) =>
        _todoRepository = todoRepository;

    public ICommandResult Handle(CreateTodoCommand command)
    {
        command.Validate();
        if (command.Invalid)
            return new GenericCommandResult(false, "Infelizmente não foi possivel criar sua tarefa", command.Notifications);

        var todo = new TodoItem(command.Title, command.Date, command.User);

        _todoRepository.Create(todo);

        return new GenericCommandResult(true, "Sua tarefa foi criada", todo);
    }
}
