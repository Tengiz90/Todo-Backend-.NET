using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBackend.Domain.Models;

namespace TodoBackend.Application.Repositories
{
    public interface TodoReposiroty
    {
        int SaveTodo(string name);
        bool DeleteTodo(int id);
        bool ToggleCompleted(int id, bool completed);
        List<Todo> GetAllTodos();

    }
}
