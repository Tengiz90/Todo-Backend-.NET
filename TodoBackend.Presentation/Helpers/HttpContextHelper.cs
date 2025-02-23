using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoBackend.Domain.Models;

namespace TodoBackend.Presentation.Helpers
{
    public static class HttpContextHelper
    {
        public static User? GetAuthUser(HttpContext httpContext)
        {
            var user = httpContext.User;
            if (user?.Identity?.IsAuthenticated == true && user.HasClaim(c => c.Type == "UserID"))
            {
                var userIdClaim = user.Claims.FirstOrDefault(c => c.Type == "UserID")?.Value;
                if (int.TryParse(userIdClaim, out int userId))
                {
                    return new User { Id = userId };
                }
            }
            return null;
        }
    }
}
