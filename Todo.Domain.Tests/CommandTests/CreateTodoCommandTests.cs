using System;
using Todo.Domain.Commands;
using Xunit;

namespace Todo.Domain.CommandTests;

public class CreateTodoCommandTests
{
    [Fact]
    public void InformarTodoCommandInvalido_Deveria()
    {
        var command = new CreateTodoCommand("t", DateTime.Now, "t");
        command.Validate();
        Assert.Equal(command.Valid, false);
    }

    [Fact]
    public void InformarTodoCommandValido_Deveria()
    {
        var command = new CreateTodoCommand("Codar até ficar very good", DateTime.Now, "leonardo Lima Pontes");
        command.Validate();
        Assert.Equal(command.Valid, true);
    }
}