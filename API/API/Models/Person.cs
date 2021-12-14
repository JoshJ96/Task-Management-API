using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    internal class Person
    {
        public string? Name { get; set; }

        public List<Task>? AssignedTasks { get; set; }
    }
}
