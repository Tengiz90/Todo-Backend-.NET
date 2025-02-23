using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoBackend.Domain.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime DateCreated { get; set; }
        public bool Completed { get; set; }
    }
}
