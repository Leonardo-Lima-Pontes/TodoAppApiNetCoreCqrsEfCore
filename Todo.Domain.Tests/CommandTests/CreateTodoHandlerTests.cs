using System;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Xunit;

public class CreateTodoHandlerTests
{
    public CreateTodoHandlerTests()
    {

    }

    [Fact]
    public void InformarTodoCommandInvalido_ParaInterromperExecucao()
    {
        var command = new CreateTodoCommand("", DateTime.Now, "");
        var handler = new TodoHandler(null);
        Assert.True(false);
    }

    [Fact]
    public void InformarTodoCommandValido_ParaCriarTarefa()
    {
        Assert.True(false);
    }
}