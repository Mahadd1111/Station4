using UnityEngine;

[CreateAssetMenu(fileName = "Task", menuName = "Station4/Task Definition")]
public class TaskDefinition : ScriptableObject
{
    [SerializeField] private string title = "New task";
    [TextArea(2, 4)]
    [SerializeField] private string description;

    public string Title => title;
    public string Description => description;
}
