using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class UpdateTodoCommand : Notifiable, ICommand
    {
        public UpdateTodoCommand() { }

        public UpdateTodoCommand(Guid id, string user, string title)
        {
            Id = id;
            User = user;
            Title = title;
        }

        public Guid Id { get; set; }
        public string? User { get; set; }
        public string? Title { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .HasMinLen(User, 6, "User", "Isuário invalido, por favor informe um usuário valido")
                    .HasMinLen(Title, 3, "Title", "Titulo invalido, por favor informe um titulo valido")
            );
        }
    }
}