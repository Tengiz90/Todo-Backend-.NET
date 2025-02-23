using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoBackend.Application.Services.Interfaces
{
    public interface IErrorLoggingService
    {
        public void SaveError(string title, int? userId);
    }
}
