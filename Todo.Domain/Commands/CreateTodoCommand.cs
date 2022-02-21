using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class CreateTodoCommand : ICommand
    {
        public CreateTodoCommand() { }

        public CreateTodoCommand(string? title, DateTime date, string user)
        {
            Title = title;
            Date = date;
            User = user;
        }

        public string? Title { get; set; }
        public DateTime Date { get; set; }
        public string? User { get; set; }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}