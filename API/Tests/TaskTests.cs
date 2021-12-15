using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Processes;
using API.Models;
using System.Collections;

namespace Tests;

public class TaskTests
{
    [Fact]
    public void TestCreateTask()
    {
        TaskProcessor taskProcessor = new TaskProcessor();
        API.Models.Task task = taskProcessor.CreateTask("My sample task", "Description of my sample task.", DateTime.Now, DateTime.Now);
        Assert.True(task != null);
    }
}