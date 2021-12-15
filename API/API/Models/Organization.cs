using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models;

public class Organization
{
    public string name { get; set; }

    public List<Person> members { get; set; }

    public Person owner { get; set; }
}