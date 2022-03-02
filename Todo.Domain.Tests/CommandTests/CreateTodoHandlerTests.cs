using System;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.FaceRepositories;
using Xunit;

namespace Todo.Domain.Tests.CommandTests;

public class CreateTodoHandlerTests
{
    public CreateTodoHandlerTests() { }

    [Fact]
    public void InformarTodoCommandInvalido_ParaInterromperExecucao()
    {
        var command = new CreateTodoCommand("", DateTime.Now, "");
        var handler = new TodoHandler(FakeTodoRepository);
        Assert.True(false);
    }

    [Fact]
    public void InformarTodoCommandValido_ParaCriarTarefa()
    {
        Assert.True(false);
    }
}