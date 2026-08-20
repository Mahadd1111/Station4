using System.Text;
using TMPro;
using UnityEngine;

public class TaskListUI : MonoBehaviour
{
    [SerializeField] private TaskManager taskManager;
    [SerializeField] private TextMeshProUGUI listText;

    private readonly StringBuilder builder = new();

    private void OnEnable()
    {
        taskManager.TaskCompleted += OnTaskCompleted;
        Redraw();
    }

    private void OnDisable()
    {
        taskManager.TaskCompleted -= OnTaskCompleted;
    }

    private void OnTaskCompleted(TaskDefinition task)
    {
        Redraw();
    }

    private void Redraw()
    {
        builder.Clear();

        foreach (TaskDefinition task in taskManager.Tasks)
        {
            if (taskManager.IsComplete(task))
            {
                builder.AppendLine($"<color=#7A7A7A><s>{task.Title}</s></color>");
            }
            else
            {
                builder.AppendLine($"• {task.Title}");
            }
        }

        listText.text = builder.ToString();
    }
}
