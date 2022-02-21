namespace Todo.Domain.Commands
{
    public interface ICommand
    {
        bool Validate();
    }
}