using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoBackend.Domain.Models;
using TodoBackend.Presentation.Helpers;

namespace TodoBackend.Presentation.Controllers
{
    public class MainController : ControllerBase
    {
        protected User? AuthUser => HttpContextHelper.GetAuthUser(HttpContext);
    }
}
