using UnityEngine;

public class TestLamp : MonoBehaviour, IInteractable
{
    [SerializeField] private Light targetLight;

    public string Prompt => targetLight.enabled ? "Turn off" : "Turn on";

    public void Interact()
    {
        targetLight.enabled = !targetLight.enabled;
    }
}