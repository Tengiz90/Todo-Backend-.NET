using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using TodoBackend.Application.Services.Interfaces;
using TodoBackend.Presentation.Helpers;

namespace TodoBackend.Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class TodoController(ITodoService todoService) : MainController
    {
        [HttpPost]
        public IActionResult SaveTodo(string title)
        {
            int userId = AuthUser!.Id;
            return Ok(todoService.SaveTodo(title, userId));
        }

    }
}
