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

    public void SetTorch(bool on)
    {
        isOn = on;
        torchLight.enabled = on;
    }
}