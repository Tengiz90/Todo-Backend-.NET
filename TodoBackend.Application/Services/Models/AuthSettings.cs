using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoBackend.Application.Services.Models
{
    public class AuthSettings
    {
        public TimeSpan AccessTokenExpires { get; set; }
        public string SecretKey { get; set; } 
    }
}
