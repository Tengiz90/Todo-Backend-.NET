using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBackend.Application.Repositories;

namespace TodoBackend.Infrastructure.Repositories.Implementations
{
    public class UsersRepository : IUsersRepository
    {
        public bool RefreshTokenAlreadyExists(string token)
        {
            return true;
        }
    }
}
