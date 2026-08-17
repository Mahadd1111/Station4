using UnityEngine;

public class TaskInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private TaskDefinition task;
    [SerializeField] private string verb = "Use";

    public string Prompt => verb;

    public void Interact()
    {
        TaskManager.Instance.CompleteTask(task);
    }
}
