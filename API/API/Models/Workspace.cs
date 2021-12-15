﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models;

public class Workspace
{
    public List<Person> members { get; set; }
    public List<Task> tasks { get; set; }
}