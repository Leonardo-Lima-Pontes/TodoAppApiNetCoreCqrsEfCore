using Todo.Domain.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace Todo.Domain.Commands
{
    public class CreateTodoCommand : Notifiable, ICommand
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
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(Title, 3, "Title", "Por favor descreva melhor esta tarefa!")
                .HasMinLen(User, 6, "User", "Por favor forneça o usuário corretamente")
            );
        }
    }
}