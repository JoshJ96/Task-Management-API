using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Events;

public class TaskEvents
{
    #region Singleton Instance

    public static TaskEvents instance = null;
    private TaskEvents()    { }
    public static TaskEvents Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new TaskEvents();
            }
            return instance;
        }
    }

    #endregion

    //Task events
    public event Action taskCreated;
    public void TaskCreated(API.Models.Task task) => taskCreated?.Invoke();
}