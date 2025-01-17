using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoBackend.Domain.Models
{
    public class ErrorLogEntry
    {
        public string Message { get; set; }
        public int UserId { get; set; }
    }
}
