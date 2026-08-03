using UnityEngine;
using UnityEngine.InputSystem;

public class Torch : MonoBehaviour
{
    [SerializeField] private Light torchLight;
    [SerializeField] private bool startOn = false;

    private bool isOn;

    public bool IsOn => isOn;

    private void Start()
    {
        SetTorch(startOn);
    }

    // Called automatically by PlayerInput (Behavior: Send Messages)
    public void OnTorch(InputValue value)
    {
        if (value.isPressed)
        {
            SetTorch(!isOn);
        }
    }

    public void SetTorch(bool on)
    {
        isOn = on;
        torchLight.enabled = on;
    }
}