using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models;

public class Task
{
    public int id { get; set; }
    public string? name { get; set; }
    public string? description { get; set; }
    public DateTime? startDate { get; set; }
    public DateTime? endDate { get; set; }
    public bool? isCompleted { get; set; }
    public HashSet<Task>? subTasks { get; set; }
    public HashSet<Task>? dependsOn { get; set; }
    public HashSet<Task>? dependedBy { get; set; }

    public Task(string? name, string? description, DateTime? startDate, DateTime? endDate)
    {
        this.name = name;
        this.description = description;
        this.startDate = startDate;
        this.endDate = endDate;
        startDate = DateTime.Now;
        endDate = DateTime.Now;
        isCompleted = false;
    }
}