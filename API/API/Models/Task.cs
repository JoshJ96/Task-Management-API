namespace API.Models;

public class Task
{
    public Guid id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public bool isCompleted { get; set; }
    public HashSet<Task> subTasks { get; set; }
    public HashSet<Task> dependsOn { get; set; }
    public HashSet<Task> dependedBy { get; set; }

    public Task(string name, string description, DateTime startDate, DateTime endDate)
    {
        this.id = Guid.NewGuid();
        this.name = name;
        this.description = description;
        this.startDate = DateTime.Now;
        this.endDate = DateTime.Now;
        this.isCompleted = false;
    }
}