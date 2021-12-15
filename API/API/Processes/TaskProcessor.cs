using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Processes;

public class TaskProcessor
{
    public static Models.Task CreateTask(string? name, string? description, DateTime? startDate, DateTime? endDate)
    {
        return new Models.Task(name, description, startDate, endDate);
    }
}