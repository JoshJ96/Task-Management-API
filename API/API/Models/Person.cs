using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models;

public class Person
{
    public string name { get; set; }

    public List<Task> assignedTasks { get; set; }
}