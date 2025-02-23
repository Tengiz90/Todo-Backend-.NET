using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBackend.Domain.Models;

namespace TodoBackend.Application.Services.Interfaces
{
    public interface ITodoService
    {
        public int SaveTodo(string title, int userId);
        public List<Todo> GetTodosByUserId(int userId);
        bool DeleteTodo(int id, int userId);
        bool ToggleCompleted(int id, int userId);
    }
}
