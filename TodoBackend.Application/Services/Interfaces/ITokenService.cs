using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBackend.Domain.Models;

namespace TodoBackend.Application.Services.Interfaces
{
    public interface ITokenService
    {
        string GetAccessToken(User user);
        string GetRefreshToken();
    }
}
