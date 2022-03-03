using System;
using FluentAssertions;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.FaceRepositories;
using Xunit;

namespace Todo.Domain.Tests.HandlerTests;

public class CreateTodoHandlerTests
{
    private readonly CreateTodoCommand _invalidTodoCommand = new CreateTodoCommand("", DateTime.Now, "");
    private readonly CreateTodoCommand _validTodoCommand = new CreateTodoCommand("Codar até ficar very good", DateTime.Now, "leonardo Lima Pontes");
    private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());
    private GenericCommandResult _result = new GenericCommandResult();
    public CreateTodoHandlerTests() { }

    [Fact]
    public void InformarTodoCommandInvalido_ParaInterromperExecucao()
    {
        _result = (GenericCommandResult)_handler.Handle(_invalidTodoCommand);
        _result.Sucess.Should().BeFalse();
    }

    [Fact]
    public void InformarTodoCommandValido_ParaCriarTarefa()
    {
        _result = (GenericCommandResult)_handler.Handle(_validTodoCommand);
        _result.Sucess.Should().BeTrue();
    }
}