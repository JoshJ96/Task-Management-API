using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    internal class Task
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public bool isCompleted { get; set; }
        public int MyProperty { get; set; }
        public List<Task>? SubTasks { get; set; }
        public List<Task>? dependsOn { get; set; }
        public List<Task>? dependedBy { get; set; }
    }
}
