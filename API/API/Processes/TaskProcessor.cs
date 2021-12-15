using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Processes;

public class TaskProcessor
{
    public TaskProcessor()
    {
        API.Events.TaskEvents.Instance.taskCreated += TaskCreated;
    }

    private void TaskCreated()
    {

    }

    public API.Models.Task CreateTask(string name, string description, DateTime startDate, DateTime endDate)
    {
        API.Models.Task createdTask = new API.Models.Task(name, description, startDate, endDate);
        API.Events.TaskEvents.Instance.TaskCreated(createdTask);
        return createdTask;
    }
}