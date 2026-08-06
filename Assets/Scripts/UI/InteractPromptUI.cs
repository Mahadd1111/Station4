using UnityEngine;
using TMPro;

public class InteractPromptUI : MonoBehaviour
{
    [SerializeField] private Interactor interactor;
    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] private string keyLabel = "E";

    private void Update()
    {
        IInteractable target = interactor.Current;

        if (target != null)
        {
            promptText.text = $"[{keyLabel}] {target.Prompt}";
            promptText.enabled = true;
        }
        else
        {
            promptText.enabled = false;
        }
    }
}