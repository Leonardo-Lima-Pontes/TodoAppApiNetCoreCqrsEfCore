using System;
using FluentAssertions;
using Todo.Domain.Entities;
using Xunit;

namespace Todo.Domain.Tests.EntityTests;

public class TodoItemTests
{
    private readonly TodoItem _todoItem = new TodoItem("Estudar C#", DateTime.Now, "leonardolimapontes");
    public TodoItemTests() { }

    [Fact]
    public void DadoUmTodoItem_DoneNaoDeveriaSerTrue() =>
        _todoItem.Done.Should().BeFalse();
}