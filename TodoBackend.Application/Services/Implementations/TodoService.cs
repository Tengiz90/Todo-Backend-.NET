using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBackend.Application.Repositories;
using TodoBackend.Application.Services.Interfaces;
using TodoBackend.Domain.Models;

namespace TodoBackend.Application.Services.Implementations
{
    public class TodoService(ITodoReposiroty todoRepository) : ITodoService
    {
        public bool DeleteTodo(int id, int userId)
        {
            return todoRepository.DeleteTodo(id, userId);
        }

        public List<Todo> GetTodosByUserId(int userId)
        {
            return todoRepository.GetTodosByUserId(userId);
        }

        public int SaveTodo(string title, int userId)
        {
             return todoRepository.SaveTodo(title, userId);
        }

        public bool ToggleCompleted(int id, int userId)
        {
            return todoRepository.ToggleCompleted(id, userId);
        }
    }
}
