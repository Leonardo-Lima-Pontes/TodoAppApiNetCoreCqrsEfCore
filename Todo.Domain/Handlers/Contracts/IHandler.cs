using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Handlers
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}