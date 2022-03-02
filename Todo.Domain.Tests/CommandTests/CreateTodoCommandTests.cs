using System;
using Todo.Domain.Commands;
using Xunit;

namespace Todo.Domain.CommandTests;

public class CreateTodoCommandTests
{
    private readonly CreateTodoCommand _invalidTodoCommand = new CreateTodoCommand("", DateTime.Now, "");
    private readonly CreateTodoCommand _validTodoCommand = new CreateTodoCommand("Codar até ficar very good", DateTime.Now, "leonardo Lima Pontes");

    public CreateTodoCommandTests()
    {
        _validTodoCommand.Validate();
        _invalidTodoCommand.Validate();
    }

    [Fact]
    public void InformarTodoCommandInvalido() =>
        Assert.Equal(_invalidTodoCommand.Valid, false);

    [Fact]
    public void InformarTodoCommandValido() =>
        Assert.Equal(_validTodoCommand.Valid, true);
}