using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBackend.Application.Services.Interfaces;

namespace TodoBackend.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        public bool RefreshTokenAlreadyExists(string token)
        {
            return true;
        }
    }
}
