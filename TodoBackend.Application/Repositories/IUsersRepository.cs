using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoBackend.Application.Repositories
{
    internal interface IUsersRepository
    {
        public bool RefreshTokenAlreadyExists(string token);
    }
}
