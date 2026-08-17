using System;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public static TaskManager Instance { get; private set; }
    [SerializeField] private List<TaskDefinition> tasks = new();

    private readonly HashSet<TaskDefinition> completed = new();

    public event Action<TaskDefinition> TaskCompleted;
    public event Action AllTasksCompleted;

    public IReadOnlyList<TaskDefinition> Tasks => tasks;

    private void Awake()
    {
        Instance = this;
    }

    public bool IsComplete(TaskDefinition task)
    {
        return completed.Contains(task);
    }

    public void CompleteTask(TaskDefinition task)
    {
        if (task == null || completed.Contains(task))
        {
            return;
        }

        completed.Add(task);
        TaskCompleted?.Invoke(task);
        Debug.Log($"Completed {completed.Count} of {tasks.Count}");

        if (completed.Count >= tasks.Count)
        {
            AllTasksCompleted?.Invoke();
        }
    }

    private void Start()
    {
        TaskCompleted += t => Debug.Log("Completed: " + t.Title);
        AllTasksCompleted += () => Debug.Log("ALL TASKS DONE");
    }
}
