using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBackend.Domain.Models;

namespace TodoBackend.Application.Repositories
{
    public interface ITodoReposiroty
    {
        int SaveTodo(string title, int userId);
        bool DeleteTodo(int id,int userId);
        bool ToggleCompleted(int id, int userId);
        List<Todo> GetTodosByUserId(int userId);

    }
}
