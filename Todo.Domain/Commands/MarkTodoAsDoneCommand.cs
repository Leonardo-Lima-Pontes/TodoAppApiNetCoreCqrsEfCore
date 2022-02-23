using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class MarkTodoAsDone : Notifiable, ICommand
    {
        public MarkTodoAsDone() { }

        public MarkTodoAsDone(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid? Id { get; set; }
        public string? User { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .HasMinLen(User, 6, "User", "Usuário invalido, por favor informe um usuário valido");
            )
        }
    }
}