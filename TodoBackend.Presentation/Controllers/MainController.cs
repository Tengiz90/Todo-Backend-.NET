using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoBackend.Domain.Models;

namespace TodoBackend.Presentation.Controllers
{
    public class MainController : ControllerBase
    {
        protected User? AuthUser
        {
            get
            {
                User? user = null;
                var currentUser = HttpContext.User;
                if (currentUser != null && currentUser.HasClaim(c => c.Type == "UserID"))
                {
                    user = new User
                    {
                        Id = int.Parse(currentUser.Claims.FirstOrDefault(c => c.Type == "UserID")?.Value ?? "0")
                    };
                }
                return user;
            }
        }
    }
}
