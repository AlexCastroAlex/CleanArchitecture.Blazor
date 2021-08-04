using CleanArchitecture.Blazor.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace CleanArchitecture.Blazor.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
